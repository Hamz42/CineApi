using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Clasificacion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClasificacionController : ControllerBase
    {
        private readonly IClasificacionServices _clasificacionServices;

        public ClasificacionController(IClasificacionServices clasificacionServices)
        {
            _clasificacionServices = clasificacionServices;
        }

        /// <summary>
        /// Devuelve todas las clasificaciones segun los filtros ingresados
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("filtrar-clasificacion")]
        public IActionResult GetAllFiltros(FiltroClasificacionRequest request)
        {
            var model = _clasificacionServices.GetAllFiltros(request);
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }       
            return Ok(CreateResponse.ResponseOk(model));
        }

    }
}
