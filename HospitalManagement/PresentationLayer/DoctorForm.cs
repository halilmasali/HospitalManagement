using HospitalManagement.BusinnesLayer;
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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }
        int appointmentId = 0, doctorId = 0;
        AppointmentDetailsController appointmentDetails;

        private void btn_save_Click(object sender, EventArgs e)
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

        private void DoctorFormClear()
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
            appointmentDetails = new AppointmentDetailsController();
            tabControl1.SelectedTab = tabPage_appointmentDetails;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_appointmentDetails)
            {
                dtGViewAppointmentDetails.DataSource = appointmentDetails.GetAppointmentDetailsList();
            }
            else if (tabControl1.SelectedTab == tabPage_patientSearch)
            {

            }
        }

        private void dtGViewAppointmentDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    appointmentId = Convert.ToInt32(dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[0].Value);
                    if (appointmentId > 0)
                    {
                        DataLayer.Patient patient = appointmentDetails.GetPatientInfoByAppointmentId(appointmentId);
                        lbl_patientName.Text = patient.PName;
                        lbl_patientLastName.Text = patient.PLastName;
                        lbl_patientPhone.Text = patient.PhoneNum;
                        lbl_patientEmail.Text = patient.Email;
                        lbl_patientDate.Text = patient.RecordDate.ToShortDateString();
                    }
                }
            }
        }
    }
}
