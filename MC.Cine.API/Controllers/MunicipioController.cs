using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.Municipio;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;

namespace MC.Cine.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipioServices _municipioServices;

        public MunicipioController(IMunicipioServices municipioServices)
        {
            _municipioServices = municipioServices;
        }

        [HttpGet("Lista-Municipio")]
        public ActionResult<IEnumerable<MunicipioDto>> GetMunicipio()
        {
            var municipio = _municipioServices.GetAll();

            if (municipio == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(municipio));
        }

        [HttpGet("Lista-Municipio/{departamentoId}")]
        public ActionResult<IEnumerable<MunicipioDto>> GetMunicipioByDepartamentoId(int departamentoId)
        {
            var municipio = _municipioServices.GetByDepartamentoId(departamentoId);

            if (municipio == null || !municipio.Any())
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(municipio));
        }
    }
}

