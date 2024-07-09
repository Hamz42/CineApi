using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Unificacion;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoProduccionRepository : GenericRepository<TipoProduccion>, ITipoProduccionRepository
    {
        public TipoProduccionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
