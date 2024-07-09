using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesClasificacionNacionalidad
{
    public int Id { get; set; }

    public int TramiteClasificacionId { get; set; }

    public int PaisId { get; set; }

    public virtual AplicacionesPaise Pais { get; set; } = null!;

    public virtual TramitesClasificacion TramiteClasificacion { get; set; } = null!;
}
