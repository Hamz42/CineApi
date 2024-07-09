using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AgentesTiposAgentesPersona
{
    public int Id { get; set; }

    public int AgentesTipoAgenteId { get; set; }

    public int PersonaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual AgentesTiposAgente AgentesTipoAgente { get; set; } = null!;

    public virtual AplicacionesPersona Persona { get; set; } = null!;
}
