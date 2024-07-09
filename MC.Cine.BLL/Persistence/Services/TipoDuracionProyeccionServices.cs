using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.GeneroObra;
using MC.Cine.DTO.Dto.Pais;
using MC.Cine.DTO.Dto.TipoDuracionProyeccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoDuracionProyeccionServices : ITipoDuracionProyeccionServices
    {
        private readonly ITipoDuracionProyeccionRepository _tipoDuracionProyeccionRepository;

        public TipoDuracionProyeccionServices(ITipoDuracionProyeccionRepository tipoDuracionProyeccionRepository)
        {
            _tipoDuracionProyeccionRepository = tipoDuracionProyeccionRepository;
        }

        /// <summary>
        /// Devuelve lista de TipoDuracion
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales TipoDuracion</UltimaActualizacion>

        public IEnumerable<TipoDuracionProyeccionDto> GetAll()
        {
            var lista = _tipoDuracionProyeccionRepository.GetAll();

            return lista.Select(x => new TipoDuracionProyeccionDto
            {
                Id = x.Id,
                Descripcion = x.Descripcion,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }
        /// <summary>
        /// Devuelve lista de TipoDuracionProyeccion activos
        /// </summary>
        /// <returns>Lista de tipo "TipoDuracionProyeccion"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        public IEnumerable<TipoDuracionProyeccionDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _tipoDuracionProyeccionRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new TipoDuracionProyeccionDto
            {
                Id = x.Id,
                Descripcion = x.Descripcion,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja
            }).ToList();
        }
    }
}
