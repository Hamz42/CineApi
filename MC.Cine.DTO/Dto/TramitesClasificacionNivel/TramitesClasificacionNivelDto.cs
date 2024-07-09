

namespace MC.Cine.DTO.Dto.TramitesClasificacionNivel
{
    public class TramitesClasificacionNivelDto
    {
        public int Id { get; set; }
        public string Nivel { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
