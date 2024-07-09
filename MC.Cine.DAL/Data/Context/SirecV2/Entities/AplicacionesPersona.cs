using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesPersona
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public int AplicacionTipoIdentificacionId { get; set; }

    public string Identificacion { get; set; } = null!;

    public int AplicacionGeneroId { get; set; }

    public int AplicacionMunicipioId { get; set; }

    public string Correo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Celular { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string HistorialJson { get; set; } = null!;

    public virtual ICollection<AgentesTiposAgentesPersona> AgentesTiposAgentesPersonas { get; set; } = new List<AgentesTiposAgentesPersona>();

    public virtual AplicacionesGenero AplicacionGenero { get; set; } = null!;

    public virtual AplicacionesMunicipio AplicacionMunicipio { get; set; } = null!;

    public virtual AplicacionesTipoIdentificacion AplicacionTipoIdentificacion { get; set; } = null!;

    public virtual ICollection<AplicacionesDatosUsuariosInterno> AplicacionesDatosUsuariosInternos { get; set; } = new List<AplicacionesDatosUsuariosInterno>();

    public virtual ICollection<AplicacionesLogin> AplicacionesLogins { get; set; } = new List<AplicacionesLogin>();
}
