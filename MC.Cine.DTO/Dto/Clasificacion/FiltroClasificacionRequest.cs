namespace MC.Cine.DTO.Dto.Clasificacion
{
    public class FiltroClasificacionRequest
    {
        public int? IdCreador { get; set; }
        public DateTime? FechaSolicitudInicio { get; set; }
        public DateTime? FechaSolicitudFin { get; set; }
        public string Obra { get; set; } = string.Empty;
        public string Responsable { get; set; } = string.Empty;
        public int? IdNivelClasificacion { get; set; }
        public int? IdEstado { get; set; }
        public int? PerfilId { get; set; }
    }
}
