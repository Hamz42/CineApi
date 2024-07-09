using MC.Cine.DAL.Data.Context.SirecV2;

namespace MC.Cine.BLL.Interfaces.Common.Base
{
    public interface IUnitOfWork : IDisposable
    {
        dbContextSirec ContextSirec { get; }

        void Commit();
    }
}
