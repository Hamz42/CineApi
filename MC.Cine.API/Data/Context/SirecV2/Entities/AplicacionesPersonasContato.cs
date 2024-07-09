using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersonasContato
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Direccion { get; set; }

    public string Email { get; set; } = null!;

    public string NumeroTelefono { get; set; } = null!;

    public string? NuemeroTelefonoAlternativo { get; set; }

    public int AplicacionMunicipioId { get; set; }

    public string? SitioWeb { get; set; }

    public int AplicacionPersonaId { get; set; }

    public virtual AplicacionesPersona AplicacionPersona { get; set; } = null!;
}
