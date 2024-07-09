using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class Juridico
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public int MunicipioId { get; set; }

    public string? DigitoVerificacion { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Celular { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? UrlPaginaWeb { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int JuridicoTipoId { get; set; }

    public virtual ICollection<AplicacionesPersonasJuridica> AplicacionesPersonasJuridicas { get; set; } = new List<AplicacionesPersonasJuridica>();

    public virtual ICollection<JuridicoRepresentanteLegal> JuridicoRepresentanteLegals { get; set; } = new List<JuridicoRepresentanteLegal>();

    public virtual JuridicoTipo JuridicoTipo { get; set; } = null!;

    public virtual AplicacionesMunicipio Municipio { get; set; } = null!;
}
