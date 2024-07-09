using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Unificacion;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoProductorRepository : GenericRepository<TipoProductor>, ITipoProductorRepository
    {
        public TipoProductorRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
