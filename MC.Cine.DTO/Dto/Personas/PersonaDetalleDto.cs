using MC.Cine.DTO.Dto.Agentes;
using MC.Cine.DTO.Dto.Genero;
using MC.Cine.DTO.Dto.Identificacion;
using MC.Cine.DTO.Dto.Municipio;

namespace MC.Cine.DTO.Dto.Personas
{
    public class PersonaDetalleDto
    {
        public PersonaDetalleDto()
        {
            TipoIdentificacion = new TipoIdentificacionDto();
            Genero = new GeneroDto();
            Municipio = new MunicipioDto();
        }

        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public TipoIdentificacionDto TipoIdentificacion { get; set; }
        public GeneroDto Genero { get; set; }
        public MunicipioDto Municipio { get; set; }
        public AgentesDetalleDto? Agente { get; set; }
        public List<AgenteTipoAgenteDto>? TipoAgente { get; set; }
    }
}
