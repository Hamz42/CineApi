using MC.Cine.DTO.Dto.JuridicoTipo;

namespace MC.Cine.DTO.Dto.Juridico
{
    public class JuridicoDetalleDto
    {
        public JuridicoDetalleDto()
        {
            RepresentanteLegal = new RepresentanteLegalDto();
            JuridicoTipo = new JuridicoTipoDto();
        }
        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public string DigitoVerificacion { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string UrlPaginaWeb { get; set; } = null!;
        public RepresentanteLegalDto RepresentanteLegal { get; set; }
        public JuridicoTipoDto JuridicoTipo { get; set; }

    }
}
