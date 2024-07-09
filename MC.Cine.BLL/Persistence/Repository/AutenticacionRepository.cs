using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using System.Data.Entity;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class AutenticacionRepository : GenericRepository<AplicacionesLogin>, IAutenticacionRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public AutenticacionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public AplicacionesLogin? GetUsuarioPorCorreo(string eMail)
        {
            var fechaActual = DateOnly.FromDateTime(DateTime.Now); // Convertir DateTime.Now a DateOnly
            var perfilWeb = _unitOfWork.ContextSirec.AplicacionesLogins
                .AsNoTracking()
                .FirstOrDefault(x => x.AplicacionPersona.Correo.Trim().ToLower() == eMail.Trim().ToLower() &&
                                (!x.FechaBaja.HasValue || x.FechaBaja.Value > fechaActual));

            return perfilWeb;
        }
    }
}
