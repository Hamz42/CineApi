﻿using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesClasificacionNivel
{
    public int Id { get; set; }

    public string Nivel { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<TramitesClasificacionActum> TramitesClasificacionActa { get; set; } = new List<TramitesClasificacionActum>();
}