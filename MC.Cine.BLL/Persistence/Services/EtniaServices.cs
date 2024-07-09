using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.Etnia;
using MC.Cine.DTO.Dto.Moneda;

namespace MC.Cine.BLL.Persistence.Services
{
    public class EtniaServices : IEtniasServices
    {
        private readonly IEtniasRepository _etniasRepository;

        public EtniaServices(IEtniasRepository etniasRepository)
        {
            _etniasRepository = etniasRepository;
        }

        /// <summary>
        /// Devuelve lista de Etnias
        /// </summary>
        /// <returns></returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de junio 2024</Fecha>
        /// <UltimaActualizacion>26 de junio 2024 - DANILO AYALA - Creacion de Listados Generales Etnias</UltimaActualizacion>

        public IEnumerable<EtniasDto> GetAll()
        {
            var lista = _etniasRepository.GetAll();

            return lista.Select(x => new EtniasDto
            {
                Id = x.Id,
                GrupoEtnico = x.GrupoEtnico,
                RequiereInformacionAdicional = x.RequiereInformacionAdicional,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }

        /// <summary>
        /// Devuelve lista de Etnia activos
        /// </summary>
        /// <returns>Lista de tipo "EtniaDto"</returns>
        /// <Autor>DANILO AYALA</Autor>
        /// <Correo>dayalab@mincultura.com</Correo>
        /// <Fecha>26 de Junio de 2024</Fecha>
        /// <UltimaActualizacion>26 de Junio de 2024 - DANILO AYALA - Creación del servicio</UltimaActualizacion>
        public IEnumerable<EtniasDto> GetAllActivos()
        {
            var fechaActual = DateTime.Now;
            var lista = _etniasRepository.Get(x => !x.FechaBaja.HasValue || x.FechaBaja > fechaActual);

            return lista.Select(x => new EtniasDto
            {
                Id = x.Id,
                GrupoEtnico = x.GrupoEtnico,
                RequiereInformacionAdicional = x.RequiereInformacionAdicional,
                FechaAlta = x.FechaAlta,
                FechaBaja = x.FechaBaja

            }).ToList();
        }
    }
}
