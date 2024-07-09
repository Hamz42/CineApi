using System;
using System.Collections.Generic;

namespace MC.Cine.DAL.Data.Context.SirecV2.Entities;

public partial class JuridicoTipo
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Juridico> Juridicos { get; set; } = new List<Juridico>();
}
