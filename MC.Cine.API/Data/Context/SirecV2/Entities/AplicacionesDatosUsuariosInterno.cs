using System;
using System.Collections.Generic;

namespace MC.Cine.API.Data.Context.SirecV2.Entities;

public partial class AplicacionesDatosUsuariosInterno
{
    public int Id { get; set; }

    public int AplicacionPersonasId { get; set; }

    public string? Cargo { get; set; }

    public int MunicipioId { get; set; }

    public virtual AplicacionesPersona AplicacionPersonas { get; set; } = null!;

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;
}
