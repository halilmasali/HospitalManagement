using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BusinnesLayer
{
    class MailSender
    {
        public static void SendMail(string to, string subject,
            string body, string attachmentPath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hospitalmanagementsmtp@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    mail.Attachments.Add(new Attachment(attachmentPath));
                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("hospitalmanagementsmtp@gmail.com", "viieknlcuqihgelo");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                System.Windows.Forms.MessageBox.Show("E-posta Gönderildi.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("E-posta gönderilirken hata oluştu: " + ex.Message); 
            }
        }
    }
}
