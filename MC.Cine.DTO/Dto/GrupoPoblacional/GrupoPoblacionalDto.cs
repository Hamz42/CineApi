namespace MC.Cine.DTO.Dto.GrupoPoblacional
{
    public class GrupoPoblacionalDto
    {
        public int Id { get; set; }
        public string GrupoPoblacional { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
