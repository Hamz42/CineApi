using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoDuracionProyeccionController : ControllerBase
    {
        private readonly ITipoDuracionProyeccionServices _tipoDuracionProyeccionServices;

        public TipoDuracionProyeccionController(ITipoDuracionProyeccionServices tipoDuracionProyeccionServices)
        {
            _tipoDuracionProyeccionServices = tipoDuracionProyeccionServices;
        }


        /// <summary>
        /// Devuelve lista de tipoDuracionProyeccion
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales tipoDuracionProyeccion</UltimaActualizacion>


        [HttpGet("lista-tipos")]
        public IActionResult GettipoDuracionProyeccion()
        {
            var tipoDuracionProyeccion = _tipoDuracionProyeccionServices.GetAll();

            if (tipoDuracionProyeccion == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(tipoDuracionProyeccion));
        }
        /// <summary>
        /// Devuelve lista de TipoDuracionProyeccion activos
        /// </summary>
        /// <returns>Lista de tipo "TipoDuracionProyeccion"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        [HttpGet("lista-tipos-activos")]
        public IActionResult GetTipoDuracionProyeccionActivos()
        {
            var TipoDuracionProyeccion = _tipoDuracionProyeccionServices.GetAllActivos();

            if (TipoDuracionProyeccion == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(TipoDuracionProyeccion));
        }
    }
}
