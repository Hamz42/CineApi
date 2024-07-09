﻿using MC.Cine.BLL.Interfaces.Common.Base;
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
    public class PaisRepository : GenericRepository<AplicacionesPaise>, IPaisRepository
    {
        public PaisRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
