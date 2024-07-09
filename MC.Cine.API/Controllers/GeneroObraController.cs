using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroObraController : ControllerBase
    {
        private readonly IGeneroObraServices _generoObraServices;

        public GeneroObraController(IGeneroObraServices generoObraServices)
        {
            _generoObraServices = generoObraServices;
        }


        /// <summary>
        /// Devuelve lista de generoObra
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales generoObra</UltimaActualizacion>


        [HttpGet("lista-generos")]
        public IActionResult GetGeneroObra()
        {
            var GeneroObra = _generoObraServices.GetAll();

            if (GeneroObra == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(GeneroObra));
        }
        /// <summary>
        /// Devuelve lista de GeneroObra activos
        /// </summary>
        /// <returns>Lista de tipo "GeneroObra"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        [HttpGet("lista-generos-activos")]
        public IActionResult GetGeneroObraActivos()
        {
            var GeneroObra = _generoObraServices.GetAllActivos();

            if (GeneroObra == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(GeneroObra));
        }
    }
}
 