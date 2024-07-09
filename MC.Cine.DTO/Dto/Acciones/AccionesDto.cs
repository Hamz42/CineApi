namespace MC.Cine.DTO.Dto.Acciones
{
    public class AccionesDto
    {
        public int Id { get; set; }
        public string Accion { get; set; } = string.Empty;
        public int NumeroAccion { get; set; }

        public int IdEstado { get; set; }
    }
}
