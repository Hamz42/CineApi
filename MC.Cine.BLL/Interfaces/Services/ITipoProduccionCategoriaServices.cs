using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using MC.Cine.DTO.Dto.TipoProduccionCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoProduccionCategoriaServices
    {
        IEnumerable<TipoProduccionCategoriaDto> GetAllTipoProduccionCategoria();
    }
}
