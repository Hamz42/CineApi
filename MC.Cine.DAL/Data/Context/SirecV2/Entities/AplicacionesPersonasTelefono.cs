using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasTelefono
{
    public int Id { get; set; }

    public string Telefono { get; set; } = null!;

    public int AplicacionesPersonaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public bool EsPrincipal { get; set; }

    public int AplicacionesTipoTelefonoId { get; set; }

    public virtual AplicacionesPersona AplicacionesPersona { get; set; } = null!;

    public virtual AplicacionesTipoTelefono AplicacionesTipoTelefono { get; set; } = null!;

    public virtual ICollection<TramitesPersonasTelefono> TramitesPersonasTelefonos { get; set; } = new List<TramitesPersonasTelefono>();
}
