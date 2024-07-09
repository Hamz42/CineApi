using MC.Cine.BLL.Base;
using MC.Cine.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.Cine.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class EtniaController : ControllerBase
    //{
    //    private readonly IEtniaServices _etniaServices;

    //    public EtniaController(IEtniaServices etniaServices)
    //    {
    //        _etniaServices = etniaServices;
    //    }

    //    /// <summary>
    //    /// Devuelve todas las etnias
    //    /// </summary>
    //    /// <returns></returns>
    //    /// <Autor>Harold Andres Zamora</Autor>
    //    /// <Correo>hamz42@hotmail.com</Correo>
    //    /// <Fecha>15 de Abril de 2024</Fecha>
    //    /// <UltimaActualizacion>15 de Abril de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
    //    [HttpGet("listar-etnias")]
    //    public IActionResult GetAllEtnias()
    //    {
    //        var etnias = _etniaServices.GetAll();
    //        if (etnias == null)
    //        {
    //            return Ok(CreateResponse.ResponseNotOk());
    //        }
    //        return Ok(CreateResponse.ResponseOk(etnias));
    //    }
    //}
}
