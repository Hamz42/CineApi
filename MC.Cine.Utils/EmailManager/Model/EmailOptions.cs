namespace MC.Cine.Utils.EmailManager.Model
{
    public class EmailOptions
    {
        public string? Host { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string? MailFrom { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
