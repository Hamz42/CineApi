using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaisesController : ControllerBase
    {
        
        private readonly IPaisesServices _paisesServices;

        public PaisesController(IPaisesServices paisesServices)
        {
            _paisesServices = paisesServices;
        }


        /// <summary>
        /// Devuelve lista de Paises
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Paises</UltimaActualizacion>

        
        [HttpGet("lista-paises")]
        public IActionResult GetPaises()
        {
            var paises = _paisesServices.GetAll();

            if (paises == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(paises));
        }
    }
}
