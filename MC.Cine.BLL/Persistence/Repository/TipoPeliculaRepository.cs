using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoPeliculaRepository : GenericRepository<AplicacionesTipoPelicula>, ITipoPeliculaRepository
    {
        public TipoPeliculaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
