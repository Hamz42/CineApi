using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesClasificacion
{
    public int Id { get; set; }

    public long TramiteId { get; set; }

    public int FormatoRodajeId { get; set; }

    public int IndicadorCineVideo { get; set; }

    public int? ProductoId { get; set; }

    public string TituloOriginal { get; set; } = null!;

    public string TituloEspañol { get; set; } = null!;

    public int GeneroObraId { get; set; }

    public int? SubGeneroObraId { get; set; }

    public int MonedaId { get; set; }

    public int TipoDuracionProyeccionId { get; set; }

    public int TipoPeliculaId { get; set; }

    public decimal MontoCancelado { get; set; }

    public string? Sinopsis { get; set; }

    public string? FichaTecnica { get; set; }

    public int? NumeroRollos { get; set; }

    public int? NumeroCopias { get; set; }

    public int? DuracionMinutos { get; set; }

    public int? DuracionSegundos { get; set; }

    public long? NumeroConsignacion { get; set; }

    public DateTime? FechaPago { get; set; }

    public int? TipoVisualizacionId { get; set; }

    public bool? TieneKdm { get; set; }

    public bool? TieneRango { get; set; }

    public int? NumeroVigenciaHoras { get; set; }

    public virtual AplicacionesFormatoRodaje FormatoRodaje { get; set; } = null!;

    public virtual AplicacionesGeneroObra GeneroObra { get; set; } = null!;

    public virtual AplicacionesMonedum Moneda { get; set; } = null!;

    public virtual TramitesProducto? Producto { get; set; }

    public virtual AplicacionesTipoDuracionProyeccion TipoDuracionProyeccion { get; set; } = null!;

    public virtual AplicacionesTipoPelicula TipoPelicula { get; set; } = null!;

    public virtual TramitesClasificacionTipoVisualizacion? TipoVisualizacion { get; set; }

    public virtual Tramite Tramite { get; set; } = null!;

    public virtual ICollection<TramitesClasificacionActum> TramitesClasificacionActa { get; set; } = new List<TramitesClasificacionActum>();

    public virtual ICollection<TramitesClasificacionNacionalidad> TramitesClasificacionNacionalidads { get; set; } = new List<TramitesClasificacionNacionalidad>();
}
