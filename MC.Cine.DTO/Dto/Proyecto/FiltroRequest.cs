namespace MC.Cine.DTO.Dto.Proyecto
{
    public class FiltroRequest
    {
        public int IdCreador { get; set; }
        public DateTime? FechaSolicitudInicio { get; set; }
        public DateTime? FechaSolicitudFin { get; set; }
        public string NombreProyecto { get; set; } = string.Empty;
        public string NombreProductor { get; set; } = string.Empty;
        public int? CodigosEstadoProyecto { get; set; }  
    }
}
