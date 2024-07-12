using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoVisualizacionRepository : GenericRepository<TramitesClasificacionTipoVisualizacion>, ITipoVisualizacionRepository
    {
        public TipoVisualizacionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
