using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoProduccionCategoriaRepository : GenericRepository<TipoProduccionCategorium>, ITipoProduccionCategoriaRepository
    {

        public TipoProduccionCategoriaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
