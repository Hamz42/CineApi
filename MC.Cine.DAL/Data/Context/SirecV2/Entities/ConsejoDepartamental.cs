using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class ConsejoDepartamental
{
    public int Id { get; set; }

    public int MunicipioId { get; set; }

    public virtual ICollection<AplicacionesPersonasConsejoDepartamental> AplicacionesPersonasConsejoDepartamentals { get; set; } = new List<AplicacionesPersonasConsejoDepartamental>();

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;
}
