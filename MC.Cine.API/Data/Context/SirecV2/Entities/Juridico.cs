using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class Juridico
{
    public int Id { get; set; }

    public string? RazonSocial { get; set; }

    public string? Nit { get; set; }

    public string? Repre { get; set; }

    public int MunicipioId { get; set; }

    public virtual ICollection<AplicacionesPersonasJuridica> AplicacionesPersonasJuridicas { get; set; } = new List<AplicacionesPersonasJuridica>();

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;
}
