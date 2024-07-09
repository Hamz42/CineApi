using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.JuridicoTipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class JuridicoTipoServices : IJuridicoTipoServices
    {
        private readonly IJuridicoTipoRepository _juridicoTipoRepository;
         
        public JuridicoTipoServices(IJuridicoTipoRepository juridicoTipoRepository)
        {
            _juridicoTipoRepository = juridicoTipoRepository;
        }

        /// <summary>
        /// Devuelve lista de juridicoTipo
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>26 de junio 2024 - DANILO AYALA - Creacion de Listados Generales juridicoTipo</UltimaActualizacion>

        public IEnumerable<JuridicoTipoDto> GetAll()
        {
            var lista = _juridicoTipoRepository.GetAll();

            return lista.Select(x => new JuridicoTipoDto
            {
                Id = x.Id,
                Tipo = x.Tipo
                 
            }).ToList();
        }

       
    }
}
