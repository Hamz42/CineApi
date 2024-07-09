using MC.Cine.Utils.EmailManager.Model;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace MC.Cine.Utils.EmailManager
{
    public class EmailSender
    {
        private readonly SmtpClient _smtpClient;
        private string _mailFrom;

        public EmailSender(IOptions<EmailOptions> options)
        {
            _smtpClient = new SmtpClient(options.Value.Host, options.Value.Port)
            {
                EnableSsl = options.Value.EnableSsl,
                Credentials = new NetworkCredential(options.Value.Username, options.Value.Password)
            };
            _mailFrom = options.Value.MailFrom!;
        }

        public async Task SendEmailAsync(string to, string subject, string body, bool isBodyHtml = false, List<string> cc = null, List<string> bcc = null, List<Attachment> attachments = null)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_mailFrom),
                To = { to },
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHtml
            };

            if (cc != null)
            {
                foreach (var address in cc)
                {
                    mailMessage.CC.Add(address);
                }
            }

            if (bcc != null)
            {
                foreach (var address in bcc)
                {
                    mailMessage.Bcc.Add(address);
                }
            }

            if (attachments != null)
            {
                foreach (var attachment in attachments)
                {
                    mailMessage.Attachments.Add(attachment);
                }
            }

            await _smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendFormattedEmailAsync(string to, string subject, string body, List<string> cc = null, List<string> bcc = null, List<Attachment> attachments = null)
        {
            // Aquí puedes agregar el código para formatear el cuerpo del correo
            var formattedBody = FormatBody(body);

            await SendEmailAsync(to, subject, formattedBody, true, cc, bcc, attachments);
        }

        private string FormatBody(string body)
        {
            // Aquí puedes agregar el código para formatear el cuerpo del correo
            return $"<html><body>{body}</body></html>";
        }
    }
}
