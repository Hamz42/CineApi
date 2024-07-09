namespace MC.Cine.DTO.Dto.Etnia
{
    public class EtniasDto
    {
        public int Id { get; set; }
        public string GrupoEtnico { get; set; } = null!;
        public bool RequiereInformacionAdicional { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
