using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesMunicipio
{
    public int Id { get; set; }

    public int DepartamentoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public virtual ICollection<Agente> Agentes { get; set; } = new List<Agente>();

    public virtual ICollection<AplicacionesPersona> AplicacionesPersonas { get; set; } = new List<AplicacionesPersona>();

    public virtual AplicacionesDepartamento Departamento { get; set; } = null!;
}
