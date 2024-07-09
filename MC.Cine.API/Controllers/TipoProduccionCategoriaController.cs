using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProduccionCategoriaController : ControllerBase
    {
        private readonly ITipoProduccionCategoriaServices _tipoProduccionCategoriaservice;

        public TipoProduccionCategoriaController(ITipoProduccionCategoriaServices tipoProduccionCategoriaServices)
        {
            _tipoProduccionCategoriaservice = tipoProduccionCategoriaServices;
        }

        [HttpGet]
        [Route("ConsultaTipoProduccionCategoria")]
        public IActionResult ConsultaTipoProduccionCategoriaserviceTramite()
        {
            var model = _tipoProduccionCategoriaservice.GetAllTipoProduccionCategoria();
            if (model == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }
            return Ok(CreateResponse.ResponseOk(model));
        }

    }
}
