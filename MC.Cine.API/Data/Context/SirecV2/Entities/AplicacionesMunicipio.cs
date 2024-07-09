using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesMunicipio
{
    public int Id { get; set; }

    public int DepartamentoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public virtual ICollection<AplicacionesDatosUsuariosInterno> AplicacionesDatosUsuariosInternos { get; set; } = new List<AplicacionesDatosUsuariosInterno>();

    public virtual ICollection<AplicacionesPersona> AplicacionesPersonas { get; set; } = new List<AplicacionesPersona>();

    public virtual ICollection<ConsejoDepartamental> ConsejoDepartamentals { get; set; } = new List<ConsejoDepartamental>();

    public virtual AplicacionesDepartamento Departamento { get; set; } = null!;

    public virtual ICollection<Juridico> Juridicos { get; set; } = new List<Juridico>();
}
