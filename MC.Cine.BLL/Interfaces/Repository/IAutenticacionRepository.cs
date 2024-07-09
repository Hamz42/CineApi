using MC.Cine.BLL.Interfaces.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;

namespace MC.Cine.BLL.Interfaces.Repository
{
    public interface IAutenticacionRepository : IGenericRepository<AplicacionesLogin>
    {
        AplicacionesLogin? GetUsuarioPorCorreo(string eMail);
    }
}
