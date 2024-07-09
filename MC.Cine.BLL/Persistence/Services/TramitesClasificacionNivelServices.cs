using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.TramitesClasificacionNivel;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TramitesClasificacionNivelServices : ITramitesClasificacionNivelServices
    {
        private readonly ITramitesClasificacionNivelRepository _tramitesClasificacionNivelRepository;

        public TramitesClasificacionNivelServices(ITramitesClasificacionNivelRepository tramitesClasificacionNivelRepository)
        {
            _tramitesClasificacionNivelRepository = tramitesClasificacionNivelRepository;
        }

        /// <summary>
        /// Devuelve lista de tramitesClasificacionNivel
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>20 de junio 2024</Fecha>
        /// <UltimaActualizacion>20 de junio 2024 - DANILO AYALA - Creacion de Listados Generales tramitesClasificacionNivel</UltimaActualizacion>

        public IEnumerable<TramitesClasificacionNivelDto> GetAll()
        {
            var lista = _tramitesClasificacionNivelRepository.GetAll();

            return lista.Select(x => new TramitesClasificacionNivelDto
            {
                Id = x.Id,
                Nivel = x.Nivel,
                Descripcion = x.Descripcion,    
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja
            }).ToList();
        }

        /// <summary>
        /// Devuelve lista de tramitesClasificacionNivel activos
        /// </summary>
        /// <returns>Lista de tipo "TramitesClasificacionNivelDto"</returns>
        /// <Autor>Harold Andres Zamora</Autor>
        /// <Correo>hamz42@hotmail.com</Correo>
        /// <Fecha>24 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>24 de Junio de 2024 - Harold Andres Zamora - Creación del servicio</UltimaActualizacion>
        public IEnumerable<TramitesClasificacionNivelDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _tramitesClasificacionNivelRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new TramitesClasificacionNivelDto
            {
                Id = x.Id,
                Nivel = x.Nivel,
                Descripcion = x.Descripcion,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja
            }).ToList();
        }
    }
}
