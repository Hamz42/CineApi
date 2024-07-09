using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class AplicacionesDepartamento
{
    public int Id { get; set; }

    public int PaisId { get; set; }

    public int Codigo { get; set; }

    public string Departamento { get; set; } = null!;

    public virtual ICollection<AplicacionesMunicipio> AplicacionesMunicipios { get; set; } = new List<AplicacionesMunicipio>();

    public virtual AplicacionesPaise Pais { get; set; } = null!;
}
