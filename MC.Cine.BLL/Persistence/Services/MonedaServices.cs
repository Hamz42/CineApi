using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.Moneda;
using MC.Cine.DTO.Dto.Pais;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class MonedaServices : IMonedaServices
    {
        private readonly IMonedaRepository _monedaRepository;

        public MonedaServices(IMonedaRepository monedaRepository)
        {
            _monedaRepository = monedaRepository;
        }

        /// <summary>
        /// Devuelve lista de Moneda
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Moneda</UltimaActualizacion>

        public IEnumerable<MonedaDto> GetAll()
        {
            var lista = _monedaRepository.GetAll();

            return lista.Select(x => new MonedaDto
            {
                Id = x.Id,
                Moneda = x.Moneda,
                Descripcion = x.Descripcion,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }

        /// <summary>
        /// Devuelve lista de Moneda activos
        /// </summary>
        /// <returns>Lista de tipo "MonedaDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        public IEnumerable<MonedaDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _monedaRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new MonedaDto
            {
                Id = x.Id,
                Moneda = x.Moneda,
                Descripcion = x.Descripcion,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja
            }).ToList();
        }
    }
}
