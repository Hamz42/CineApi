﻿using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Repository
{
    public class TipoDuracionProyeccionRepository : GenericRepository<AplicacionesTipoDuracionProyeccion>, ITipoDuracionProyeccionRepository
    {
        public TipoDuracionProyeccionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
 