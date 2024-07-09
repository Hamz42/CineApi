using MC.Cine.DTO.Dto.Acciones;

namespace MC.Cine.DTO.Dto.Clasificacion
{
    public class ClasificacionDto
    {
        public int Id { get; set; }
        public  long TramiteId { get; set; }
        public string Obra { get; set; } = string.Empty;
        public string NivelClasificacion { get; set; } = string.Empty;
        public int NivelClasificacionId { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime? Fecha { get; set; }
        public DateTime? FechaClasificacion { get; set; }
        public List<AccionesDto>? Acciones { get; set; }
    }
}
