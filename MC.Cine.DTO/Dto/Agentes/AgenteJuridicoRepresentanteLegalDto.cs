using MC.Cine.DTO.Dto.Identificacion;

namespace MC.Cine.DTO.Dto.Agentes
{
    public class AgenteJuridicoRepresentanteLegalDto
    {
        public AgenteJuridicoRepresentanteLegalDto()
        {
            TipoIdentificacion = new TipoIdentificacionDto();
        }
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public TipoIdentificacionDto TipoIdentificacion { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
