using AutoMapper;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using MC.Cine.DTO.Dto.Autenticacion;
using MC.Cine.Utils.EmailManager;
using MC.Cine.Utils.EmailManager.Model;
using MC.Cine.Utils.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MC.Cine.BLL.Persistence.Services
{
    public class AutenticacionServices : IAutenticacionServices
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IAutenticacionRepository _usuarioRepository;
        //private readonly IPerfilRepository _perfilRepository;
        private readonly EmailSender _emailSender;
        private readonly IOptions<EmailOptions> _emailOptions;

        public AutenticacionServices(IConfiguration configuration, IMapper mapper, IAutenticacionRepository usuarioRepository, EmailSender emailSender, IOptions<EmailOptions> emailOptions)
        {
            _configuration = configuration;
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
            _emailSender = emailSender;
            _emailOptions = emailOptions;
            //_perfilRepository = perfilRepository;
        }

        //Dado un correo y una contraseña, se verifica si el usuario existe en la base de datos y si la contraseña es correcta
        public async Task<LoginUsuarioDto> LoginAsync(LoginUsuarioRequest request)
        {
            string publicKey = _configuration.GetValue<string>("Security:PublicKey") ?? string.Empty;
            string masterKey = _configuration.GetSection("Security:MasterKey").Value ?? string.Empty;
            
            var perfilWeb = _usuarioRepository.GetUsuarioPorCorreo(request.EMail);

            if (perfilWeb == null)
            {
                return new LoginUsuarioDto { EstadoAutenticacion = new EstadoAutenticacion{ Error = true, Mensaje = "Usuario o contraseña invalido" } };
            }

            if (!masterKey.Equals(request.Password))
            {
                var passwordDesEncrypt = new Criptografia().DesEncriptar(publicKey, perfilWeb.Password);
                
                if (!passwordDesEncrypt.Equals(request.Password))
                {
                    return new LoginUsuarioDto { EstadoAutenticacion = new EstadoAutenticacion { Error = true, Mensaje = "Usuario o contraseña invalido" } };
                }
            }

            return await DatosUsuario(perfilWeb);
        }

        public Task<bool> ValidarTokenAsync(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();

            try
            {
                tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }


        #region Metodos Privados

        //Dado un perfilWeb, se obtienen los datos del usuario para generar el token
        private async Task<LoginUsuarioDto> DatosUsuario(AplicacionesLogin perfilWeb)
        {
            var model = await ValidarUsuario(perfilWeb);

            if (model.EstadoAutenticacion.Error)
            {
                return model;
            }

            model = new LoginUsuarioDto
            {
                //Id = Convert.ToInt32(perfilWeb.AdmUsuarios?.FirstOrDefault()?.UsuId),
                IdPerfil = perfilWeb.AplicacionesModulosPerfilesAplicacionLogins.FirstOrDefault()!.AplicacionesModulosPerfilId,
                //EsPersonaNatural = perfilWeb.CodPersonaNatural.HasValue,
                //Nombre = perfilWeb.CodPersonaNatural.HasValue ? perfilWeb.CodPersonaNaturalNavigation?.NombresPersonaNatural 
                //    : perfilWeb.CodPersonaJuridicaNavigation?.NomresRepLegal,
                //Apellido = perfilWeb.CodPersonaNatural.HasValue ? perfilWeb.CodPersonaNaturalNavigation?.ApellidosPersonaNatural 
                //    : perfilWeb.CodPersonaJuridicaNavigation?.ApellidosRepLegal,
                //NombreCompleto = perfilWeb.CodPersonaNatural.HasValue ? 
                //    string.Format("{0} {1}",perfilWeb.CodPersonaNaturalNavigation?.NombresPersonaNatural, 
                //        perfilWeb.CodPersonaNaturalNavigation?.ApellidosPersonaNatural) 
                //            : perfilWeb.CodPersonaJuridicaNavigation?.RazonSocial,
                Id = perfilWeb.Id,
                Nombre = perfilWeb.AplicacionPersona.Nombres,
                Apellido = perfilWeb.AplicacionPersona.Apellidos,
                NombreCompleto = $"{perfilWeb.AplicacionPersona.Nombres} {perfilWeb.AplicacionPersona.Apellidos}",
                CorreoElectronico = perfilWeb.AplicacionPersona.Correo,
                EsResponsableCertificado = false //perfilWeb.EsResponsableCertificado ?? false,
            };

            //if (perfilWeb?.AdmUsuarios?.FirstOrDefault()?.Pers.Any() == true)
            //{
            //    var perfiles = perfilWeb?.AdmUsuarios?.FirstOrDefault()?.Pers;
            //    foreach (var perfil in perfiles!)
            //    {
            //        model.Roles.Add(perfil.PerNombre.ToLower());
            //    }
            //}
            //else
            //{
            //var perfil = await _perfilRepository.FindAsync(2); //Perfil Productor
            //if (perfil != null)
            //{
            //    model.Roles.Add(perfil.PerNombre.ToLower());
            //}
            //}

            //var perfilesUsuario = perfilWeb?.AdmUsuarios?.FirstOrDefault()?.Pers;

            model.Token = GenerarToken(model);
            
            return model;
        }

        //Dado un perfilWeb, se valida si el usuario esta activo y si la cuenta esta validada
        private async Task<LoginUsuarioDto> ValidarUsuario(AplicacionesLogin perfilWeb)
        {
            var fechaActual = DateTime.Now;
            EstadoAutenticacion result = new EstadoAutenticacion();
            if ( !perfilWeb.Activo)
            {
                string url = _configuration["UrlSitioWeb"]!;
                string asunto = @"Se registro su solicitud para crear una cuenta en el portal de tramites de la DACMI";
                string body = "CREACIÓN CUENTA TRÁMITE COMO PROYECTO NACIONAL"
                    + "<br>Para realizar la activación de su cuenta, ingrese en el siguiente link <a href='" 
                    + url + "frm/seguridad/frmValidarUsuario?cod=" 
                    + perfilWeb.Id + "'>activar cuenta</a>";

                try
                {
                    var email = perfilWeb.AplicacionPersona.Correo;
                    await new EmailSender(_emailOptions).SendEmailAsync(email, asunto, body, true);
                    result.Error = true;
                    result.Mensaje = "Cuenta no validada, se envio el correo de validación de cuenta nuevamente.";
                }
                catch (Exception)
                {
                    result.Error = true;
                    result.Mensaje = "Cuenta no validada, el servidor de correo esta presentando problemas técnicos.";
                }
            }
            //else if (perfilWeb.AdmUsuarios?.FirstOrDefault()?.UsuActivo.HasValue == false || perfilWeb.AdmUsuarios?.FirstOrDefault()?.UsuActivo == false)
            else if (!perfilWeb.Activo)
            {
                result.Error = true;
                result.Mensaje = "Usuario inactivo.";
            }
            else
            {
                result.Error = false;
                result.Mensaje = string.Empty;
            }

            return new LoginUsuarioDto { EstadoAutenticacion = result };
        }
        
        //Dado un usuario, se genera un token con los datos del usuario
        private string GenerarToken(LoginUsuarioDto usuarioDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? string.Empty));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            var claims = new[]
            {
                new Claim("Id",  usuarioDto.Id.ToString()),
                new Claim(ClaimTypes.NameIdentifier,  usuarioDto.CorreoElectronico!),
                new Claim(ClaimTypes.GivenName,  usuarioDto.Nombre!),
                new Claim(ClaimTypes.Surname,  usuarioDto.Apellido!),
                new Claim(ClaimTypes.Email, usuarioDto.CorreoElectronico!)
            };

            foreach (var rol in usuarioDto.Roles)
            {
                claims.Append(new Claim(ClaimTypes.Role, rol));
            }

            var 
                token = new JwtSecurityToken(_configuration["Jwt:Issuer"], 
                _configuration["Jwt:Audience"], 
                claims, 
                expires: DateTime.Now.AddMinutes(10), 
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _configuration["Jwt:Issuer"],
                ValidAudience = _configuration["Jwt:Audience"],
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? string.Empty))
            };
        }

        #endregion
    }
}
