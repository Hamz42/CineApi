using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.GrupoPoblacional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class GrupoPoblacionalServices : IGrupoPoblacionalServices
    {
        private readonly IGrupoPoblacionalRepository _grupoPoblacionalRepository;

        public GrupoPoblacionalServices(IGrupoPoblacionalRepository grupoPoblacionalRepository)
        {
            _grupoPoblacionalRepository = grupoPoblacionalRepository;
        }

        /// <summary>
        /// Devuelve lista de grupoPoblacional
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales grupoPoblacional</UltimaActualizacion>

        public IEnumerable<GrupoPoblacionalDto> GetAll()
        {
            var lista = _grupoPoblacionalRepository.GetAll();

            return lista.Select(x => new GrupoPoblacionalDto
            {
                Id = x.Id,
                GrupoPoblacional = x.GrupoPoblacional,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }

        /// <summary>
        /// Devuelve lista de GrupoPoblacional activos
        /// </summary>
        /// <returns>Lista de tipo "GrupoPoblacionalDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>26 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        public IEnumerable<GrupoPoblacionalDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _grupoPoblacionalRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new GrupoPoblacionalDto
            {
                Id = x.Id,
                GrupoPoblacional = x.GrupoPoblacional,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }
    }
}
