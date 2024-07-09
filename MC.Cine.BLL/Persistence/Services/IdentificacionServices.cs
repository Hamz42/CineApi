using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Identificacion;
using MC.Cine.DTO.Dto.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class IdentificacionServices : IIdentificacionServices
    {
        private readonly IIdentificacionRepository _identificacionRepository;

        public IdentificacionServices(IIdentificacionRepository identificacionRepository)
        {
            _identificacionRepository = identificacionRepository;
        }

        /// <summary>
        /// Devuelve lista de TipoIdentificacion
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales TipoIdentificacion</UltimaActualizacion>

        public IEnumerable<TipoIdentificacionDto> GetAll()
        {
            var lista = _identificacionRepository.GetAll();

            return lista.Select(x => new TipoIdentificacionDto
            {
                Id = x.Id,
                TipoIdentificacion = x.TipoIdentificacion

            }).ToList();
        }

    }
}
