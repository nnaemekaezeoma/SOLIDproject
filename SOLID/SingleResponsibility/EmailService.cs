using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility
{
    //Single Responsibility
    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
