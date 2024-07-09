using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.DAL.Data.Context.SirecV2;

namespace MC.Cine.BLL.Persistence.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        public dbContextSirec ContextSirec { get; }

        public UnitOfWork(dbContextSirec contextSirec)
        {
            ContextSirec = contextSirec;
        }

        public void Commit()
        {
            ContextSirec.SaveChangesAsync();
        }

        public void Dispose()
        {
            ContextSirec.Dispose();
        }
    }
}
