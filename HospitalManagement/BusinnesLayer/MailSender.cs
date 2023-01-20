using System;
using System.Net;
using System.Net.Mail;

namespace HospitalManagement.BusinnesLayer
{
    //Email Gönderme işlemleri için MailSender class'ı oluşturuldu.
    class MailSender
    {
        //Mail gönderme metodu ile kullanıcı mail adresi, mail konusu,
        //mail içeriği ve eklenecek dosya yolu gönderilerek mail
        //gönderme işlemi yapılır
        public static void SendMail(string to, string subject,
            string body, string attachmentPath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                //Gönderen(Sunucu) mail adresi tanımlanıyor.
                mail.From = new MailAddress("hospitalmanagementsmtp@gmail.com");
                mail.To.Add(to); //Alıcı Mail adresi tanımlanıyor.
                mail.Subject = subject; //Mail konusu tanımlanıyor.
                mail.Body = body;//Mail içeriği tanımlanıyor.
                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    //Dosya yolu boş değilse maile dosya ekleniyor.
                    mail.Attachments.Add(new Attachment(attachmentPath));
                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Gmail için smtp sunucu adresi ayarlanıyor.
                smtp.Port = 587; //sunucu port adresi ayarlanıyor.
                //Gönderen Mail Hesapının oturum bilgileri giriliyor.
                smtp.Credentials = new NetworkCredential(
                    "hospitalmanagementsmtp@gmail.com", "viieknlcuqihgelo");                
                smtp.EnableSsl = true; //Güvenli bağlantı için ssl aktif ediliyor.
                smtp.Send(mail); //smtp bağlantsı ile mail gönderimi yapılıyor.
                System.Windows.Forms.MessageBox.Show("E-posta Gönderildi.");
            }
            catch (Exception ex)
            {
                //Email gönderilirken oluşabilecek hatalar kullanıcıya gösteriliyor.
                System.Windows.Forms.MessageBox.Show("E-posta gönderilirken hata oluştu: " + ex.Message); 
            }
        }
    }
}
