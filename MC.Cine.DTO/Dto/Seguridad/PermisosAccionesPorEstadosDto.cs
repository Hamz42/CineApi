namespace MC.Cine.DTO.Dto.Seguridad
{
    public class PermisosAccionesPorEstadosDto
    {
        public int EstadoId { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Accion { get; set; } = string.Empty;
        public int NumeroAccion { get; set; }
        public int AccionId { get; set; }
    }
}
