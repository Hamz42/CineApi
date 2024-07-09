using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Agentes;
using MC.Cine.DTO.Dto.Departamento;
using MC.Cine.DTO.Dto.Genero;
using MC.Cine.DTO.Dto.Identificacion;
using MC.Cine.DTO.Dto.JuridicoTipo;
using MC.Cine.DTO.Dto.Municipio;
using MC.Cine.DTO.Dto.Pais;
using MC.Cine.DTO.Dto.Personas;

namespace MC.Cine.BLL.Persistence.Services
{
    public class PersonaServices : IPersonaServices
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaServices(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        /// <summary>
        /// Devuelve lista de Personas
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Personas</UltimaActualizacion>

        public IEnumerable<PersonasDto> GetAll()
        {
            var fechaActual = DateTime.Now;
            var lista = _personaRepository.GetAll();

            return lista.Select(x => new PersonasDto
            {
                Id = x.Id,
                Nombres = x.Nombres,
                Apellidos = x.Apellidos,
                Email = x.Correo,
                Telefono = x.Telefono,
                Direccion = x.Direccion,
                AplicacionTipoIdentificacionId = x.AplicacionTipoIdentificacionId,
                Identificacion = x.Identificacion,
                Celular = x.Celular!,
                AplicacionGeneroId = x.AplicacionGeneroId,
                MunicipioId = x.AplicacionMunicipioId,
            }).ToList();
        }

        /// <summary>
        /// Devuelve lista de Personas activos
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Detalle de Persona de tipo "PersonaDetalleDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>24 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>24 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public PersonaDetalleDto Find(int id)
        {
            var fechaActual = DateTime.Now;
            var persona = _personaRepository.Find(id);

            if (persona == null)
            {
                return new PersonaDetalleDto();
            }

            var  result = new PersonaDetalleDto
            {
                Id = persona.Id!,
                Nombres = persona.Nombres,
                Apellidos = persona.Apellidos,
                Email = persona.Correo,
                Telefono = persona.Telefono,
                Direccion = persona.Direccion,
                Identificacion = persona.Identificacion,
                Celular = persona.Celular!,
                TipoIdentificacion = new TipoIdentificacionDto
                {
                    Id = persona.AplicacionTipoIdentificacion.Id,
                    TipoIdentificacion = persona.AplicacionTipoIdentificacion.TipoIdentificacion
                },
                Genero = new GeneroDto
                {
                    Id = persona.AplicacionGenero.Id,
                    Genero = persona.AplicacionGenero.Genero
                },
                Municipio = new MunicipioDto
                {
                    Id = persona.AplicacionMunicipio.Id,
                    Municipio = persona.AplicacionMunicipio.Municipio,
                    Codigo = persona.AplicacionMunicipio.Codigo,
                    DepartamentoId = persona.AplicacionMunicipio.DepartamentoId,
                    Departamento = new DepartamentoDto
                    {
                        Id = persona.AplicacionMunicipio.Departamento.Id,
                        Departamento = persona.AplicacionMunicipio.Departamento.Departamento,
                        Codigo = persona.AplicacionMunicipio.Departamento.Codigo,
                        Pais = new PaisDto
                        {
                            Id = persona.AplicacionMunicipio.Departamento.Pais.Id,
                            Pais = persona.AplicacionMunicipio.Departamento.Pais.Pais,
                            CodigoIso = persona.AplicacionMunicipio.Departamento.Pais.CodigoIso,
                            PaisEn = persona.AplicacionMunicipio.Departamento.Pais.PaisEn,
                            CodigoTelefonico = persona.AplicacionMunicipio.Departamento.Pais.CodigoTelefonico
                        }
                    }
                },
                TipoAgente = persona.AgentesTiposAgentesPersonas
                    .Where(t => (!t.FechaBaja.HasValue || t.FechaBaja > fechaActual) &&
                                    !t.AgentesTipoAgente.FechaBaja.HasValue || t.AgentesTipoAgente.FechaBaja > fechaActual)
                    .Select(t => new AgenteTipoAgenteDto
                    {
                        Id = t.AgentesTipoAgente.Id,
                        AgenteTipo = t.AgentesTipoAgente.AgenteTipo.AgenteTipo,
                        AgenteTipoId = t.AgentesTipoAgente.AgenteTipoId
                    })
                    .ToList(),
                Agente = persona.AgentesTiposAgentesPersonas
                    .Where(t => (!t.FechaBaja.HasValue || t.FechaBaja > fechaActual) &&
                                    !t.AgentesTipoAgente.FechaBaja.HasValue || t.AgentesTipoAgente.FechaBaja > fechaActual)
                    .Select(t => new AgentesDetalleDto
                    {
                        Id = t.AgentesTipoAgente.Agente.Id,
                        TipoPersona = new TipoPersonaDto
                        {
                            Id = t.AgentesTipoAgente.Agente.TipoPersona.Id,
                            TipoPersona = t.AgentesTipoAgente.Agente.TipoPersona.TipoPersona
                        },
                        TipoIdentificacion = new TipoIdentificacionDto
                        {
                            Id = t.AgentesTipoAgente.Agente.TipoIdentificacion.Id,
                            TipoIdentificacion = t.AgentesTipoAgente.Agente.TipoIdentificacion.TipoIdentificacion
                        },
                        Identificacion = t.AgentesTipoAgente.Agente.Identificacion,
                        Municipio = new MunicipioDto
                        {
                            Id = t.AgentesTipoAgente.Agente.Municipio.Id,
                            Municipio = t.AgentesTipoAgente.Agente.Municipio.Municipio,
                            Codigo = t.AgentesTipoAgente.Agente.Municipio.Codigo,
                            DepartamentoId = t.AgentesTipoAgente.Agente.Municipio.DepartamentoId,
                            Departamento = new DepartamentoDto
                            {
                                Id = t.AgentesTipoAgente.Agente.Municipio.Departamento.Id,
                                Departamento = t.AgentesTipoAgente.Agente.Municipio.Departamento.Departamento,
                                Codigo = t.AgentesTipoAgente.Agente.Municipio.Departamento.Codigo,
                                Pais = new PaisDto
                                {
                                    Id = t.AgentesTipoAgente.Agente.Municipio.Departamento.Pais.Id,
                                    Pais = t.AgentesTipoAgente.Agente.Municipio.Departamento.Pais.Pais,
                                    CodigoIso = t.AgentesTipoAgente.Agente.Municipio.Departamento.Pais.CodigoIso,
                                    PaisEn = t.AgentesTipoAgente.Agente.Municipio.Departamento.Pais.PaisEn,
                                    CodigoTelefonico = t.AgentesTipoAgente.Agente.Municipio.Departamento.Pais.CodigoTelefonico
                                }
                            }
                        },
                        Correo = t.AgentesTipoAgente.Agente.Correo!,
                        Direccion = t.AgentesTipoAgente.Agente.Direccion!,
                        Telefono = t.AgentesTipoAgente.Agente.Telefono!,
                        Celular = t.AgentesTipoAgente.Agente.Celular!,
                        AgenteNatural = t.AgentesTipoAgente.Agente.AgentesNaturales
                            .Where(a => !a.FechaBaja.HasValue || a.FechaBaja > fechaActual)
                            .Select(a => new AgenteNaturalDto
                            {
                                Id = a.Id,
                                Nombres = a.Nombres,
                                Apellidos = a.Apellidos,
                            })
                            .FirstOrDefault(),
                        AgenteJuridico = t.AgentesTipoAgente.Agente.AgentesJuridicos
                            .Where(a => !a.FechaBaja.HasValue || a.FechaBaja > fechaActual)
                            .Select(a => new AgenteJuridicoDto
                            {
                                Id = a.Id,
                                RazonSocial = a.RazonSocial,
                                DigitoVerificacion = a.DigitoVerificacion!,
                                JuridicoTipo = a.JuridicoTipo != null ? new JuridicoTipoDto
                                {
                                    Id = a.JuridicoTipo!.Id,
                                    Tipo = a.JuridicoTipo!.Tipo
                                } : null,
                                UrlPaginaWeb = a.UrlPaginaWeb!,
                                RepresentanteLegal = a.AgentesJuridicosRepresentanteLegals
                                    .Where(r => !r.FechaBaja.HasValue || r.FechaBaja > fechaActual)
                                    .OrderByDescending(r => r.Id)
                                    .Select(r => new AgenteJuridicoRepresentanteLegalDto
                                    {
                                        Id = r.Id,
                                        Apellidos = r.Apellidos!,
                                        Nombres = r.Nombres!,
                                        Identificacion = r.Identificacion!,
                                        Email = r.Email!,
                                        Celular = r.Celular!,
                                        Telefono = r.Telefono!,
                                        TipoIdentificacion = new TipoIdentificacionDto
                                        {
                                            Id = r.TipoIdentificacion.Id,
                                            TipoIdentificacion = r.TipoIdentificacion.TipoIdentificacion
                                        }
                                    })
                                    .ToList()
                            })
                            .FirstOrDefault(),
                    })
                    .FirstOrDefault(),
            };

            return result;
        }       
    }
}
