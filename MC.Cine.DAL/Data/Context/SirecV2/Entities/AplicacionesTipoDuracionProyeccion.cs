﻿using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesTipoDuracionProyeccion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
