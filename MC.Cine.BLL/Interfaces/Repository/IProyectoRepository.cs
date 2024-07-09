using MC.Cine.DTO.Dto.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Interfaces.Repository
{
    public interface IProyectoRepository
    {
        IEnumerable<ProyectoDto> GetAllFiltros(FiltroRequest request);
    }
}
