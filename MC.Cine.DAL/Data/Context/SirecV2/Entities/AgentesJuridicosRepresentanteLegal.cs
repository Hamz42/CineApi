using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesJuridicosRepresentanteLegal
{
    public int Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public int TipoIdentificacionId { get; set; }

    public string Identificacion { get; set; } = null!;

    public int JuridicoId { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public string? Email { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual AgentesJuridico Juridico { get; set; } = null!;

    public virtual AplicacionesTipoIdentificacion TipoIdentificacion { get; set; } = null!;
}
