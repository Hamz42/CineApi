using Azure.Core;
using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using MC.Cine.DTO.Dto.Clasificacion;
using MC.Cine.DTO.Dto.EstadosTramite;
using System;
using System.Data.Entity;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class EstadosRepository : GenericRepository<AplicacionesEstado>, IEstadoRepository
    {
        public EstadosRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
