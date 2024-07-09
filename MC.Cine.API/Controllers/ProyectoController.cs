using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Proyecto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private readonly IProyectoServices _proyectoServices;

        public ProyectoController(IProyectoServices proyectoServices)
        {
            _proyectoServices = proyectoServices;
        }

        /// <summary>
        /// Devuelve todos los proyectos segun los filtros ingresados
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("filtrar-proyectos")]
        public IActionResult GetAllFiltros(FiltroRequest request)
        {
            var model = _proyectoServices.GetAllFiltros(request);

            return Ok(CreateResponse.ResponseOk(model));
        }

    }
}
