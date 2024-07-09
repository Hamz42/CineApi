using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class Tramite
{
    public long Id { get; set; }

    public int TramiteTipoId { get; set; }

    public int LoginId { get; set; }

    public int EstadoId { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual AplicacionesLogin Login { get; set; } = null!;

    public virtual TramiteTipo TramiteTipo { get; set; } = null!;

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();

    public virtual ICollection<TramitesEstado> TramitesEstados { get; set; } = new List<TramitesEstado>();

    public virtual ICollection<TramitesProducto> TramitesProductos { get; set; } = new List<TramitesProducto>();

    public virtual ICollection<TramitesProyecto> TramitesProyectos { get; set; } = new List<TramitesProyecto>();
}
