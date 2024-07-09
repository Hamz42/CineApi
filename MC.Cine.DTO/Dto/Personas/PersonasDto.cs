
namespace MC.Cine.DTO.Dto.Personas
{
    public class PersonasDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int AplicacionTipoIdentificacionId { get; set; }
        public string Identificacion { get; set; } = null!;
        public int AplicacionTipoPersonaId { get; set; }
        public int AplicacionGeneroId { get; set; }
        public int MunicipioId { get; set; }
    }
    
}
