using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.GeneroObra;
using MC.Cine.DTO.Dto.Pais;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class GeneroObraServices : IGeneroObraServices
    {
        private readonly IGeneroObraRepository  _generoObraRepository;

        public GeneroObraServices(IGeneroObraRepository generoObraRepository)
        {
            _generoObraRepository = generoObraRepository;
        }

        /// <summary>
        /// Devuelve lista de GeneroObra
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales GeneroObra</UltimaActualizacion>

        public IEnumerable<GeneroObraDto> GetAll()
        {
            var lista = _generoObraRepository.GetAll();

            return lista.Select(x => new GeneroObraDto
            {
                Id = x.Id,
                Genero = x.Genero,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }
        /// <summary>
        /// Devuelve lista de GeneroObra activos
        /// </summary>
        /// <returns>Lista de tipo "GeneroObra"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>25 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>25 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        public IEnumerable<GeneroObraDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _generoObraRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new GeneroObraDto
            {
                Id = x.Id,
                Genero = x.Genero,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja
            }).ToList();
        }

    }
}
