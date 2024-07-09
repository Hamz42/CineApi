using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class TramitesPersonasTelefono
{
    public int Id { get; set; }

    public int TramitesPersonasId { get; set; }

    public int PersonasTelefonoId { get; set; }

    public virtual AplicacionesPersonasTelefono PersonasTelefono { get; set; } = null!;

    public virtual TramitesPersona TramitesPersonas { get; set; } = null!;
}
