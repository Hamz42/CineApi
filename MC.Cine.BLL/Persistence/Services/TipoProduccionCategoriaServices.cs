using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.EstadosTramite;
using MC.Cine.DTO.Dto.TipoProduccionCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class TipoProduccionCategoriaServices : ITipoProduccionCategoriaServices
    {
        private readonly ITipoProduccionCategoriaRepository _tipoProduccionCategoriaRepository;

        public TipoProduccionCategoriaServices(ITipoProduccionCategoriaRepository tipoProduccionCategoriaRepository)
        {
            _tipoProduccionCategoriaRepository = tipoProduccionCategoriaRepository;
        }

        public IEnumerable<TipoProduccionCategoriaDto> GetAllTipoProduccionCategoria()
        {
            var lista = _tipoProduccionCategoriaRepository.GetAll();
            return lista.Select(x => new TipoProduccionCategoriaDto
            {
                Id = x.Id,
                Nombre = x.TipoCategoria ?? string.Empty
            }).ToList();
        }
    }
}
