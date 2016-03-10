using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace PITP
{
    public class SendEmail
    {
        public static void SendMail(string textbody, string subject, string mailFrom, string mailTo)
        {
            using (var client = new SmtpClient("relay.hostinguk.net"))
            {
                MailAddress recipient = new MailAddress(mailFrom, "Party in the Park website");
                MailAddress to = new MailAddress(mailTo, "Party in the Park website");
                MailMessage message = new MailMessage(recipient, to);
                message.Subject = subject;
                message.Body = textbody;
                message.IsBodyHtml = true;
                client.Send(message);
            }
        }
    }
}