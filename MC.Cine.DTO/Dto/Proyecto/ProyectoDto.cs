namespace MC.Cine.DTO.Dto.Proyecto
{
    public class ProyectoDto
    {
        public int IdEstado { get; set; }
        public int Id { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Productor { get; set; } = string.Empty;
        public string NombreProyecto { get; set; } = string.Empty;
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaSolicitudAclaraciones { get; set; }
        public DateTime? FechaReciboAclaraciones { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public DateTime? FechaNotificacionAclaratoria { get; set; }
        public DateTime? FechaTramiteFin { get; set; }
        public DateTime? FechaLimite { get; set; }
        public string RutaResolucion { get; set; } = string.Empty;
        public int MesesTotales { get; set; }
    }
}
