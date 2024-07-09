using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        private readonly IAutenticacionServices _autenticacionservice;
        private readonly IMapper _mapper;

        public AutenticacionController(IAutenticacionServices autenticacionServices, IMapper mapper)
        {
            _autenticacionservice = autenticacionServices;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUsuarioRequest request)
        {
            var model = await _autenticacionservice.LoginAsync(request);
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }

        [HttpGet("validarToken")]
        public async Task<IActionResult> ValidarToken([FromQuery] string token)
        {
            var model = await _autenticacionservice.ValidarTokenAsync(token);
            return Ok(CreateResponse.ResponseOk(model));
        }

    }
}
