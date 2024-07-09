using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesProducto
{
    public int Id { get; set; }

    public long TramiteId { get; set; }

    public int? ProyectoId { get; set; }

    public int? TipoProduccionId { get; set; }

    public string? NombreProduccion { get; set; }

    public int? TipoProduccionCategoriaId { get; set; }

    public int? GeneroProduccionId { get; set; }

    public string? Sinopsis { get; set; }

    public int? DuracionId { get; set; }

    public decimal? CostoTotalDesarrolloProduccion { get; set; }

    public decimal? CostoTotalPreProduccion { get; set; }

    public decimal? CostoTotalProduccion { get; set; }

    public decimal? CostoTotalPosProduccion { get; set; }

    public decimal? CostoTotalPromocionProduccion { get; set; }

    public int? LugaresGrabacionId { get; set; }

    public bool? TieneDirectorColombiano { get; set; }

    public DateOnly? FechaComienzoFilmacion { get; set; }

    public DateOnly? FechaFinFilmacion { get; set; }

    public string? ObservacionesFechaFilmacion { get; set; }

    public int? LugarDepositoObraFisicaId { get; set; }

    public string? ComentariosAdicionalesProduccion { get; set; }

    public int? RevisionAclaracionesId { get; set; }

    public int? PorcentajeProducto { get; set; }

    public virtual TramitesProyecto? Proyecto { get; set; }

    public virtual TipoProduccionCategorium? TipoProduccionCategoria { get; set; }

    public virtual Tramite Tramite { get; set; } = null!;

    public virtual ICollection<TramitesClasificacion> TramitesClasificacions { get; set; } = new List<TramitesClasificacion>();
}
