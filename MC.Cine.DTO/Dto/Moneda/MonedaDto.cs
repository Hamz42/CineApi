
namespace MC.Cine.DTO.Dto.Moneda
{
    public class MonedaDto
    {
        public int Id { get; set; }
        public string Moneda { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
