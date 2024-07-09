using AutoMapper;
using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using MC.Cine.DTO.Dto.Genero;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Authorization;

namespace MC.Cine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IGenerosServices _generosServices;

        public GenerosController(IGenerosServices generosServices)
        {
            _generosServices = generosServices;
        }


        /// <summary>
        /// Devuelve lista de generos
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales generos</UltimaActualizacion>


        [HttpGet("Lista-Generos")]
        public IActionResult GetGeneros()
        {
            var generos = _generosServices.GetAll();

            if (generos == null)
            {
                return Ok(CreateResponse.ResponseNotOk());
            }

            return Ok(CreateResponse.ResponseOk(generos));
        }
    }
}
