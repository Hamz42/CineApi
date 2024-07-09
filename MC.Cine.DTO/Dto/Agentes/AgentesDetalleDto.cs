using MC.Cine.DTO.Dto.Identificacion;
using MC.Cine.DTO.Dto.Municipio;
using MC.Cine.DTO.Dto.Personas;

namespace MC.Cine.DTO.Dto.Agentes
{
    public class AgentesDetalleDto
    {
        public AgentesDetalleDto()
        {
            TipoPersona = new TipoPersonaDto();
            TipoIdentificacion = new TipoIdentificacionDto();
            Municipio = new MunicipioDto();
        }

        public int Id { get; set; }
        public TipoPersonaDto TipoPersona { get; set; }
        public TipoIdentificacionDto TipoIdentificacion { get; set; }
        public MunicipioDto Municipio { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public AgenteNaturalDto? AgenteNatural { get; set; }
        public AgenteJuridicoDto? AgenteJuridico { get; set; }
    }
}
