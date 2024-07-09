using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasCorreo
{
    public int Id { get; set; }

    public string Correo { get; set; } = null!;

    public int AplicacionesPersonaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual AplicacionesPersona AplicacionesPersona { get; set; } = null!;

    public virtual ICollection<TramitesPersona> TramitesPersonas { get; set; } = new List<TramitesPersona>();
}
