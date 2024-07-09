using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.Departamento;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;

namespace MC.Cine.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentoServices _departamentoServices;

        public DepartamentoController(IDepartamentoServices departamentoServices)
        {
            _departamentoServices = departamentoServices;
        }

        [HttpGet("Lista-Departamentos")]
        public ActionResult<IEnumerable<DepartamentoDto>> GetDepartamentos()
        {
            var departamentos = _departamentoServices.GetAll();

            if (departamentos == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(departamentos));
        }

        [HttpGet("Lista-Departamentos/{paisId}")]
        public ActionResult<IEnumerable<DepartamentoDto>> GetDepartamentosByPaisId(int paisId)
        {
            var departamentos = _departamentoServices.GetByPaisId(paisId);

            if (departamentos == null || !departamentos.Any())
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(departamentos));
        }
    }
}

