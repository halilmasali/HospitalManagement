using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_secretary_Click(object sender, EventArgs e)
        {
            SecretaryForm secretary = new SecretaryForm();
            this.Hide();
            secretary.ShowDialog();
            this.Show();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctor = new DoctorForm();
            this.Hide();
            doctor.ShowDialog();
            this.Show();
        }
    }
}
