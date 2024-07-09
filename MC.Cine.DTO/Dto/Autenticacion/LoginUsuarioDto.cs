namespace MC.Cine.DTO.Dto.Autenticacion
{
    public class LoginUsuarioDto
    {
        public LoginUsuarioDto()
        {
            EstadoAutenticacion = new EstadoAutenticacion();
        }

        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NombreCompleto { get; set; }
        public string? CorreoElectronico { get; set; }
        public bool EsPersonaNatural { get; set; }
        public bool EsResponsableCertificado { get; set; }
        public string? Token { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public EstadoAutenticacion EstadoAutenticacion { get; set; }

    }

    public class EstadoAutenticacion
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; } = string.Empty;
    }
}
