using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesGenero
{
    public int Id { get; set; }

    public string Genero { get; set; } = null!;

    public virtual ICollection<AgentesGenero> AgentesGeneros { get; set; } = new List<AgentesGenero>();

    public virtual ICollection<AplicacionesPersona> AplicacionesPersonas { get; set; } = new List<AplicacionesPersona>();
}
