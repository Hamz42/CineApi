using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServices _personaServices;

        public PersonaController(IPersonaServices personaServices)
        {
            _personaServices = personaServices;
        }


        /// <summary>
        /// Devuelve lista de persona
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales persona</UltimaActualizacion>


        [HttpGet("lista-persona")]
        public IActionResult Getpersona()
        {
            var persona = _personaServices.GetAll();
            if (persona == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(persona));
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
        [HttpGet("obtener-persona/id/{id}")]
        public IActionResult GetPersona(int id)
        {
            var persona = _personaServices.Find(id);
            if (persona == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(persona));
        }
    }
}
