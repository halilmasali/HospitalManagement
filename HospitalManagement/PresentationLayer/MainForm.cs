using System;
using System.Windows.Forms;

namespace HospitalManagement.PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        BusinnesLayer.SecretaryControl secretary = new BusinnesLayer.SecretaryControl(); //Sekreter için controller oluşturuluyor.
        BusinnesLayer.DoctorControl doctor = new BusinnesLayer.DoctorControl(); //Doktor için controller oluşturuluyor.
        private short auth_type = 0;
        //Sekreter ve Doktor girişini ayırt etmek için değişken tanımı
        //auth_type 0 --> Tanımsız
        //auth_type 1 --> Sekreter
        //auth_type 2 --> Doktor
        private void btn_secretary_Click(object sender, EventArgs e)
        {
            grp_auth.Visible = true;
            auth_type = 1;            
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            grp_auth.Visible = true;
            auth_type = 2;            
        }

        private void btn_auth_Click(object sender, EventArgs e) //Authentication işlemi için kontroller sağlanıyor.
        {
            if (txt_phoneNum.Text != "" && txt_password.Text != "")
            {
                if (auth_type == 1)
                {
                    if (secretary.SecretaryAuth(txt_phoneNum.Text,txt_password.Text))
                    {
                        SecretaryForm secretary = new SecretaryForm();
                        this.Hide();
                        secretary.ShowDialog();
                        ClearAuthForm();
                        this.Show();                        
                    }
                    else
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.");
                }
                else if (auth_type == 2)
                {
                    if (doctor.DoctorAuth(txt_phoneNum.Text, txt_password.Text))
                    {
                        DoctorForm doctor = new DoctorForm();
                        this.Hide();
                        doctor.ShowDialog();
                        ClearAuthForm();
                        this.Show();                        
                    }
                    else
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Giriniz.");
            }
        }

        //Form Temizleniyor
        private void ClearAuthForm()
        {
            txt_phoneNum.Text = "";
            txt_password.Text = "";
            grp_auth.Visible = false;
        }
    }
}
