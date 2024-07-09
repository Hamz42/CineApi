using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesTipoIdentificacion
{
    public int Id { get; set; }

    public string TipoIdentificacion { get; set; } = null!;

    public virtual ICollection<Agente> Agentes { get; set; } = new List<Agente>();

    public virtual ICollection<AgentesJuridicosRepresentanteLegal> AgentesJuridicosRepresentanteLegals { get; set; } = new List<AgentesJuridicosRepresentanteLegal>();

    public virtual ICollection<AplicacionesPersona> AplicacionesPersonas { get; set; } = new List<AplicacionesPersona>();
}
