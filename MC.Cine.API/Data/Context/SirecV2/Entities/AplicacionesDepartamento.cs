using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesDepartamento
{
    public int Id { get; set; }

    public int PaisId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public virtual ICollection<AplicacionesMunicipio> AplicacionesMunicipios { get; set; } = new List<AplicacionesMunicipio>();

    public virtual AplicacionesPaise Pais { get; set; } = null!;
}
