using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesPaise
{
    public int Id { get; set; }

    public string Pais { get; set; } = null!;

    public string CodigoIso { get; set; } = null!;

    public string PaisEn { get; set; } = null!;

    public string CodigoTelefonico { get; set; } = null!;

    public virtual ICollection<AplicacionesDepartamento> AplicacionesDepartamentos { get; set; } = new List<AplicacionesDepartamento>();

    public virtual ICollection<TramitesClasificacionNacionalidad> TramitesClasificacionNacionalidads { get; set; } = new List<TramitesClasificacionNacionalidad>();
}
