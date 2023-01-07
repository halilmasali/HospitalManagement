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
        int secretaryId = 1, patientId;
        private void Form1_Load(object sender, EventArgs e)
        {            
            secretary = new SecretaryControl();
            patient = new PatientController();
            cmb_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
            cmb_patient.Items.AddRange(PatientController.getPatients().ToArray());
        }

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

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            if (cmb_branch.SelectedItem != null && cmb_doctor.SelectedItem != null && 
                cmb_patient.SelectedItem != null && cmb_clock.SelectedItem != null &&
                dt_date.Value != null)
            {
                int branchId = ((Branch)cmb_branch.SelectedItem).BranchId;
                int doctorId = ((Doctor)cmb_doctor.SelectedItem).DoctorId;
                int patientId = ((Patient)cmb_patient.SelectedItem).PatientId;
                DateTime dateTime = dt_date.Value.Date + TimeSpan.Parse(cmb_clock.SelectedItem.ToString());
                secretary.CreateAppointment(branchId, doctorId, patientId,secretaryId, dateTime);
            }
        }

        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            if (txt_patient_name.Text != "" && txt_patient_lastname.Text != "" &&
                txt_patient_email.Text != "" && txt_patient_phone.Text != "")
            {

                if (patient.AddPatientRecord(txt_patient_name.Text,txt_patient_lastname.Text,
                    txt_patient_phone.Text,txt_patient_email.Text))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    txt_patient_name.Text = "";
                    txt_patient_lastname.Text = "";
                    txt_patient_email.Text = "";
                    txt_patient_phone.Text = "";
                    dtGViewPatient.DataSource = patient.GetPatientsList();
                } 
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_Patient)
            {
                dtGViewPatient.DataSource = patient.GetPatientsList();
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
                    txt_patient_name.Text = "";
                    txt_patient_lastname.Text = "";
                    txt_patient_email.Text = "";
                    txt_patient_phone.Text = "";
                    dtGViewPatient.DataSource = patient.GetPatientsList();
                }
            }
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
    }
}
