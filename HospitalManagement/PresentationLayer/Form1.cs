using HospitalManagement.BusinnesLayer;
using HospitalManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SecretaryControl secretary;
        PatientController patient;
        AppointmentController appointment;
        int secretaryId = 1, patientId = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            secretary = new SecretaryControl();
            patient = new PatientController();
            appointment = new AppointmentController();
            tabControl1.SelectedTab = tabPage_Appointment;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_Appointment)
            {
                dtGViewAppointment.DataSource = appointment.GetAppointmentList();
                cmb_branch.Items.Clear();
                cmb_patient.Items.Clear();
                cmb_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
                cmb_patient.Items.AddRange(PatientController.getPatients().ToArray());
            }
            else if (tabControl1.SelectedTab == tabPage_Patient)
            {
                dtGViewPatient.DataSource = patient.GetPatientsList();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedTab == tabPage_Appointment)
            //{
            //    //dtGViewAppointment.DataSource = 
            //    cmb_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
            //    cmb_patient.Items.AddRange(PatientController.getPatients().ToArray());
            //}
            //else if (tabControl1.SelectedTab == tabPage_Patient)
            //{
            //    dtGViewPatient.DataSource = patient.GetPatientsList();
            //}
        }
       


        #region Appointment Tab View Code
        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doctor.Text = "";
            cmb_doctor.Items.Clear();
            if (cmb_branch.SelectedItem != null)
            {
                cmb_doctor.Items.AddRange(
                    secretary.getDoctorsByBranch(
                        ((Branch)cmb_branch.SelectedItem).BranchId).ToArray());
                cmb_doctor.Enabled = true;
            }
        }

        private void btn_appointment_create_Click(object sender, EventArgs e)
        {
            if (cmb_branch.SelectedItem != null && cmb_doctor.SelectedItem != null &&
                cmb_patient.SelectedItem != null && cmb_clock.SelectedItem != null &&
                dt_date.Value != null)
            {
                int branchId = ((Branch)cmb_branch.SelectedItem).BranchId;
                int doctorId = ((Doctor)cmb_doctor.SelectedItem).DoctorId;
                int patientId = ((Patient)cmb_patient.SelectedItem).PatientId;
                DateTime dateTime = dt_date.Value.Date + TimeSpan.Parse(cmb_clock.SelectedItem.ToString());
                secretary.CreateAppointment(branchId, doctorId, patientId, secretaryId, dateTime);
            }
        }
        #endregion

        #region Patient Tab View Code 
        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            if (txt_patient_name.Text != "" && txt_patient_lastname.Text != "" &&
                txt_patient_email.Text != "" && txt_patient_phone.Text != "")
            {

                if (patient.AddPatientRecord(txt_patient_name.Text, txt_patient_lastname.Text,
                    txt_patient_phone.Text, txt_patient_email.Text))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    PatientFormClear();
                }
            }
        }

        private void btn_patient_update_Click(object sender, EventArgs e)
        {
            if (txt_patient_name.Text != "" && txt_patient_lastname.Text != "" &&
                txt_patient_email.Text != "" && txt_patient_phone.Text != "")
            {

                if (patient.UpdatePatientRecord(patientId, txt_patient_name.Text,
                    txt_patient_lastname.Text, txt_patient_phone.Text, txt_patient_email.Text))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    PatientFormClear();
                }
            }
        }

        private void btn_patient_delete_Click(object sender, EventArgs e)
        {
            if (patientId > 0)
            {
                DialogResult dialog = MessageBox.Show(patientId + " numaralı hastayı silmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (patient.DeletePatientRecord(patientId))
                    {
                        MessageBox.Show(patientId + " numaralı hasta silindi.", "Bilgi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PatientFormClear();
                    }
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Silmek istediğiniz veri için tablodan hasta seçiniz." +
                    "(Seçim işlemini hasta bilgisine çift tıklayarak yapabilirsiniz.)", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtGViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewPatient.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    patientId = Convert.ToInt32(dtGViewPatient.Rows[e.RowIndex].Cells[0].Value);
                    txt_patient_name.Text = dtGViewPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_patient_lastname.Text = dtGViewPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_patient_phone.Text = dtGViewPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_patient_email.Text = dtGViewPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void txt_patient_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_patient_search.Text != null)
                {
                    dtGViewPatient.DataSource = patient.SearchPatientRecord(txt_patient_search.Text);
                }
            }
        }

        private void PatientFormClear()
        {
            patientId = 0;
            txt_patient_name.Text = "";
            txt_patient_lastname.Text = "";
            txt_patient_email.Text = "";
            txt_patient_phone.Text = "";
            dtGViewPatient.DataSource = patient.GetPatientsList();
        }
        #endregion


    }
}
