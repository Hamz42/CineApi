namespace MC.Cine.DTO.Dto.Agentes
{
    public class AgentesDatosBasicosDto
    {
        public int Id { get; set; }
        public string NombreRazonSocial { get; set; } = null!;
        public int TipoIdentificacionId { get; set; }
        public string TipoIdentificacion { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public int AgenteTipoId { get; set; }
        public string AgenteTipo { get; set; } = null!;
    }
}
