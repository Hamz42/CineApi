using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesLogin
{
    public int Id { get; set; }

    public int AplicacionPersonaId { get; set; }

    public string Password { get; set; } = null!;

    public bool Activo { get; set; }

    public int NumeroIntentos { get; set; }

    public DateOnly FechaAlta { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public bool EsUsuarioInterno { get; set; }

    public virtual AplicacionesPersona AplicacionPersona { get; set; } = null!;

    public virtual ICollection<AplicacionesModulosPerfilesAplicacionLogin> AplicacionesModulosPerfilesAplicacionLogins { get; set; } = new List<AplicacionesModulosPerfilesAplicacionLogin>();

    public virtual ICollection<Tramite> Tramites { get; set; } = new List<Tramite>();
}
