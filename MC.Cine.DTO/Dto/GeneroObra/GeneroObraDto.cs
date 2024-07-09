
namespace MC.Cine.DTO.Dto.GeneroObra
{
    public class GeneroObraDto
    {
        public int Id { get; set; }
        public string Genero { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
 