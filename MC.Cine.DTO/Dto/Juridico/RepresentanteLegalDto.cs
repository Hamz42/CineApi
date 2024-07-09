using MC.Cine.DTO.Dto.Identificacion;
namespace MC.Cine.DTO.Dto.Juridico
{
    public class RepresentanteLegalDto
    {
        public RepresentanteLegalDto()
        {
            TipoIdentificacion = new TipoIdentificacionDto();
        }

        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public TipoIdentificacionDto TipoIdentificacion { get; set; } = null!;

    }
}
