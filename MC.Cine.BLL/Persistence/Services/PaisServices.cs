using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class PaisServices : IPaisesServices
    {
        private readonly IPaisRepository _paisRepository;

        public PaisServices(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        /// <summary>
        /// Devuelve lista de Paises
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Paises</UltimaActualizacion>

        public IEnumerable<PaisDto> GetAll()
        {
            var lista = _paisRepository.GetAll();

            return lista.Select(x => new PaisDto
            {
                Id = x.Id,
                Pais = x.Pais,
                CodigoIso = x.CodigoIso,
                PaisEn = x.PaisEn,
                CodigoTelefonico = x.CodigoTelefonico
            }).ToList();
        }
    }
}
