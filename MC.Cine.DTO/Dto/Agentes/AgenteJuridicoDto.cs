using MC.Cine.DTO.Dto.JuridicoTipo;

namespace MC.Cine.DTO.Dto.Agentes
{
    public class AgenteJuridicoDto
    {
        public AgenteJuridicoDto()
        {
            RepresentanteLegal = new List<AgenteJuridicoRepresentanteLegalDto>();
        }

        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string DigitoVerificacion { get; set; } = null!;
        public string UrlPaginaWeb { get; set; } = null!;
        public JuridicoTipoDto? JuridicoTipo { get; set; }
        public List<AgenteJuridicoRepresentanteLegalDto> RepresentanteLegal { get; set; }
    }
}
