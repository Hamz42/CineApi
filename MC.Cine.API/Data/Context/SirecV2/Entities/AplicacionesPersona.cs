using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersona
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Celular { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int AplicacionTipoIdentificacionId { get; set; }

    public string Identificacion { get; set; } = null!;

    public int AplicacionTipoPersonaId { get; set; }

    public int AplicacionGeneroId { get; set; }

    public int MunicipioId { get; set; }

    public virtual AplicacionesGenero AplicacionGenero { get; set; } = null!;

    public virtual AplicacionesTipoIdentificacion AplicacionTipoIdentificacion { get; set; } = null!;

    public virtual AplicacionesTipoPersona AplicacionTipoPersona { get; set; } = null!;

    public virtual ICollection<AplicacionesDatosUsuariosInterno> AplicacionesDatosUsuariosInternos { get; set; } = new List<AplicacionesDatosUsuariosInterno>();

    public virtual ICollection<AplicacionesLogin> AplicacionesLogins { get; set; } = new List<AplicacionesLogin>();

    public virtual ICollection<AplicacionesPersonasConsejoDepartamental> AplicacionesPersonasConsejoDepartamentals { get; set; } = new List<AplicacionesPersonasConsejoDepartamental>();

    public virtual ICollection<AplicacionesPersonasContato> AplicacionesPersonasContatos { get; set; } = new List<AplicacionesPersonasContato>();

    public virtual ICollection<AplicacionesPersonasJuridica> AplicacionesPersonasJuridicas { get; set; } = new List<AplicacionesPersonasJuridica>();

    public virtual ICollection<AplicacionesPersonasProfesion> AplicacionesPersonasProfesions { get; set; } = new List<AplicacionesPersonasProfesion>();

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;
}
