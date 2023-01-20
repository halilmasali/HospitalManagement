using HospitalManagement.BusinnesLayer; //BusinessLayer'a ulaşmak için gerekli. 
using HospitalManagement.DataLayer;
using System;
using System.Drawing; //Yazdırma işlemleri için gerekli.
using System.Text; //StringBuilder kullanımı için gerekli.
using System.Windows.Forms;

namespace HospitalManagement.PresentationLayer
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }
        int appointmentId = 0;
        AppointmentDetailsController appointmentDetails; //RandevuDetay için controller referansı oluşturuluyor.
        DoctorControl doctor;
        Doctor doctorSession;
        private void btn_save_Click(object sender, EventArgs e) //RandevuDetaylarını kaydeder.
        {
            if (txt_patientNote.Text != "")
            {
                if (appointmentId > 0)
                {
                    if (appointmentDetails.AddAppointmentNote(appointmentId, txt_patientNote.Text))
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        DoctorFormClear();
                    }
                }
                else
                    MessageBox.Show("Öncelikle randevu seçimi yapmalısınız.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş not kaydedilemez.");
        }

        private void DoctorFormClear() //Form ekranını temizler.
        {
            appointmentId = 0;
            txt_patientNote.Text = "";
            lbl_patientName.Text = "";
            lbl_patientLastName.Text = "";
            lbl_patientPhone.Text = "";
            lbl_patientEmail.Text = "";
            lbl_patientDate.Text = "";
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            appointmentDetails = new AppointmentDetailsController(); //RandevuDetay için controller oluşturuluyor.
            doctor = new DoctorControl(); //Doctor için controller oluşturuluyor.            
            doctorSession = doctor.GetDoctorSession();//oturum açan doktor bilgisi alındı.
            this.Text += " - " + doctorSession.DName + " " +
                doctorSession.DLastName;//doktor ismi form başlığına yazıldı.
                                        //Controller aracılığıyla RandevuDetay tablsou DGW'a yazdırılıyor.
            dtGViewAppointmentDetails.DataSource = appointmentDetails.GetAppointmentListbyDoctor(doctorSession.DoctorId);
        }

        //DGW'da veriye çift tıklayınca label'lara bilgiler yazılıyor.
        private void dtGViewAppointmentDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    appointmentId = Convert.ToInt32(dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[0].Value);
                    if (appointmentId > 0)
                    {
                        Patient patient = appointmentDetails.GetPatientInfoByAppointmentId(appointmentId);
                        lbl_patientName.Text = patient.PName;
                        lbl_patientLastName.Text = patient.PLastName;
                        lbl_patientPhone.Text = patient.PhoneNum;
                        lbl_patientEmail.Text = patient.Email;
                        lbl_patientDate.Text = patient.RecordDate.ToShortDateString();
                        PatientRecord record = appointmentDetails.GetAppointmentNoteByAppointmentId(appointmentId);
                        txt_patientNote.Text = record.Note;
                    }
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e) //Yazdırma işlemi
        {
            if (lbl_patientName.Text != "" && lbl_patientLastName.Text != "" && lbl_patientPhone.Text != "" &&
                    lbl_patientDate.Text != "")
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir randevu kaydı seçiniz." +
                    "(Seçim işlemini randevu bilgisine çift tıklayarak yapabilirsiniz.)", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //doktor görüşlerinin yer aldığı textbox'ın içeriğini pdf'e dönüştürürken tek satır
        //halinde değil de paragraf halinde yazmasını sağlamak amacıyla kullanılacak method
        public static string AddLineBreaks(string input, int maxLength)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = input.Split(' ');
            int lineLength = 0;
            foreach (string word in words)
            {
                if (lineLength + word.Length > maxLength)
                {
                    sb.AppendLine();
                    lineLength = 0;
                }
                sb.Append(word + " ");
                lineLength += word.Length + 1;
            }
            return sb.ToString();
        }

        //Yazdırma işlemi için sayfa düzeni oluşturuluyor.
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) 
        {
            try
            {
                Font font = new Font("Arial", 10);  //font nesnesi oluşturuluyor.
                SolidBrush firca = new SolidBrush(Color.Black); //yazıyı yazması için fırça nesnesi oluşturuluyor
                Pen kalem = new Pen(Color.Black); //çizgi çizilmesi için kalem nesnesi oluşturuluyor.
                
                //drawstring methoduyla istenilen yazı yazdırılıyor
                e.Graphics.DrawString($"Rapor Tarihi: {DateTime.Now.ToString("dd.MM.yyyy")}", font, firca, 50, 25); 

                font = new Font("Arial", 18, FontStyle.Bold);
                e.Graphics.DrawString("Hasta Randevu Detayları - Sonuçları", font, firca, 195, 100);

                e.Graphics.DrawLine(kalem, 50, 190, 780, 190);
                e.Graphics.DrawLine(kalem, 50, 365, 780, 365);
                e.Graphics.DrawLine(kalem, 50, 190, 50, 365);
                e.Graphics.DrawLine(kalem, 780, 190, 780, 365);
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString("Hasta Bilgileri", font, firca, 60, 200);

                int x = 60;
                int y = 240;
                font = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString("Adı Soyadı: ", font, firca, x, y);
                e.Graphics.DrawString("E-mail: ", font, firca, x, y + 30);
                e.Graphics.DrawString("Telefon Numarası: ", font, firca, x, y + 60);
                e.Graphics.DrawString("Randevu Tarihi: ", font, firca, x, y + 90);

                x = 300;
                font = new Font("Arial", 14);
                e.Graphics.DrawString(lbl_patientName.Text + " " + lbl_patientLastName.Text, font, firca, x, y);
                e.Graphics.DrawString(lbl_patientEmail.Text, font, firca, x, y + 30);
                e.Graphics.DrawString(lbl_patientPhone.Text, font, firca, x, y + 60);
                Patient patient = appointmentDetails.GetPatientInfoByAppointmentId(appointmentId);
                e.Graphics.DrawString(dtGViewAppointmentDetails.SelectedRows[0].Cells[2].Value.ToString(), font, firca, x, y + 90);

                e.Graphics.DrawLine(kalem, 50, 420, 780, 420);
                e.Graphics.DrawLine(kalem, 50, 900, 780, 900);
                e.Graphics.DrawLine(kalem, 50, 420, 50, 900);
                e.Graphics.DrawLine(kalem, 780, 420, 780, 900);
                y = 430;
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString("Doktor Görüşleri", font, firca, 60, y);

                y = 470;
                string input = txt_patientNote.Text;
                int maxLength = 85;
                string output = AddLineBreaks(input, maxLength);
                font = new Font("Arial", 14);
                e.Graphics.DrawString(output, font, firca, 60, y);

                font = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString("Doktor Ad Soyad", font, firca, 600, 950);
                e.Graphics.DrawString("İmza", font, firca, 660, 975);
                font = new Font("Arial", 14);
                e.Graphics.DrawString("Dr. " + doctorSession.DName + " " + doctorSession.DLastName, font, firca, 600, 1010);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata :" + exception.Message);
            }
        }

        //Mail gönderme işlemi
        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            if (lbl_patientName.Text != "" && lbl_patientLastName.Text != "" && lbl_patientPhone.Text != "" &&
                    lbl_patientDate.Text != "" && txt_patientNote.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Hasta görüşlerini göndermek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    MailSender.SendMail(
                        lbl_patientEmail.Text,
                        lbl_patientName.Text + " " + lbl_patientLastName.Text + " Randevu Sonucu",
                        txt_patientNote.Text,
                        null);
                }
                else
                    MessageBox.Show("Gönderme işlemi iptal edildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir randevu kaydı seçiniz." +
                    "(Seçim işlemini randevu bilgisine çift tıklayarak yapabilirsiniz.)", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
