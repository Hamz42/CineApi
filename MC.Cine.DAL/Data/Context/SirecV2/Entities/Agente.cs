using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class Agente
{
    public int Id { get; set; }

    public int TipoPersonaId { get; set; }

    public int TipoIdentificacionId { get; set; }

    public string Identificacion { get; set; } = null!;

    public int MunicipioId { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string HistorialJson { get; set; } = null!;

    public virtual ICollection<AgentesConsejoDepartamental> AgentesConsejoDepartamentals { get; set; } = new List<AgentesConsejoDepartamental>();

    public virtual ICollection<AgentesEtnium> AgentesEtnia { get; set; } = new List<AgentesEtnium>();

    public virtual ICollection<AgentesGenero> AgentesGeneros { get; set; } = new List<AgentesGenero>();

    public virtual ICollection<AgentesGrupoPoblacional> AgentesGrupoPoblacionals { get; set; } = new List<AgentesGrupoPoblacional>();

    public virtual ICollection<AgentesJuridico> AgentesJuridicos { get; set; } = new List<AgentesJuridico>();

    public virtual ICollection<AgentesNaturale> AgentesNaturales { get; set; } = new List<AgentesNaturale>();

    public virtual ICollection<AgentesProfesion> AgentesProfesions { get; set; } = new List<AgentesProfesion>();

    public virtual ICollection<AgentesTiposAgente> AgentesTiposAgentes { get; set; } = new List<AgentesTiposAgente>();

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;

    public virtual AplicacionesTipoIdentificacion TipoIdentificacion { get; set; } = null!;

    public virtual AplicacionesTipoPersona TipoPersona { get; set; } = null!;
}
