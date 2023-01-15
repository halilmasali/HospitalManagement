using HospitalManagement.BusinnesLayer; //BusinessLayer'a ulaşmak için gerekli. 
using HospitalManagement.DataLayer; //DataLayer'a' ulaşmak için gerekli. 
using System;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class SecretaryForm : Form
    {
        public SecretaryForm()
        {
            InitializeComponent();
        }
        SecretaryControl secretary; //secretary parametresi oluşturuldu.
        PatientController patient; //patient parametresi oluşturuldu.
        AppointmentController appointment; //appointment parametresi oluşturuldu.
        DoctorControl doctor;//doctor paramatresi oluşturuldu
        Secretary secretarySession;//Oturum açan sekter parametresi oluşturuldu.
        int secretaryId = 0, patientId = 0, appointmentId = 0, doctorId = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            secretary = new SecretaryControl(); //Sekreter için controller oluşturuluyor.
            patient = new PatientController(); //Hasta için controller oluşturuluyor.
            appointment = new AppointmentController(); //Randevu için controller oluşturuluyor.
            doctor = new DoctorControl(); //Doktor için controller oluşturuluyor.
            tabControl1.SelectedTab = tabPage_Appointment; //Seçili Tab, Randevu olarak ayarlanıyor.
            dt_date.MinDate = DateTime.Today; //DateTime öğesi için seçilebilecek ilk tarih
                                              //bugünden itibaren olacak şekilde ayarlanıyor.
            secretarySession = secretary.GetSecretarySession();//oturum açan sekreter bilgisi alındı.
            this.Text += " - " + secretarySession.Name + " " + 
                secretarySession.LastName;//sekreter ismi form başlığına yazıldı.
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_Appointment) //Seçilen tab, randevu ise;
            {
                dtGViewAppointment.DataSource = appointment.GetAppointmentList(); //Controller aracılığıyla Randevu tablsou DGW'a yazdırılıyor.
                cmb_branch.Items.Clear();
                cmb_patient.Items.Clear();
                cmb_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
                cmb_patient.Items.AddRange(PatientController.getPatients().ToArray());
            }
            else if (tabControl1.SelectedTab == tabPage_Patient) //Seçilen tab, hasta ise;
            {
                dtGViewPatient.DataSource = patient.GetPatientsList(); //Controller aracılığıyla Hasta tablsou DGW'a yazdırılıyor.
            }
            else if (tabControl1.SelectedTab == tabPage_Doctor) //Seçilen tab, doktor ise;
            {
                dtGViewDoctor.DataSource = doctor.GetDoktorsList(); //Controller aracılığıyla Doktor tablsou DGW'a yazdırılıyor.
                cmb_doctor_branch.Items.Clear();
                cmb_doctor_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
            }
            else if (tabControl1.SelectedTab == tabPage_Secreter) //Seçilen tab, sekreter ise;
            {
                dtGViewSecreter.DataSource = secretary.GetSecretarysList(); //Controller aracılığıyla Sekreter tablsou DGW'a yazdırılıyor.
            }
            else if (tabControl1.SelectedTab == tabPage_statistic)
            {
                GetStatistic();
            }
        }

        #region Appointment Tab View Code
        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e) //Branş seçimine göre doktor combobox'ına ilgili doktorları yazar.
        {
            cmb_doctor.Text = "";
            cmb_doctor.Items.Clear();
            if (cmb_branch.SelectedItem != null)
            {
                cmb_doctor.Items.AddRange(
                    doctor.getDoctorsByBranch(
                        ((Branch)cmb_branch.SelectedItem).BranchId).ToArray());
                cmb_doctor.Enabled = true;
            }
        }

        private void btn_appointment_create_Click(object sender, EventArgs e) //Yeni randevu oluşturma event'i
        {
            if (cmb_branch.SelectedItem != null && cmb_doctor.SelectedItem != null &&
                cmb_patient.SelectedItem != null && cmb_clock.SelectedItem != null &&
                dt_date.Value != null)
            {
                int branchId = ((Branch)cmb_branch.SelectedItem).BranchId;
                int doctorId = ((Doctor)cmb_doctor.SelectedItem).DoctorId;
                int patientId = ((Patient)cmb_patient.SelectedItem).PatientId;
                DateTime dateTime = dt_date.Value.Date + TimeSpan.Parse(cmb_clock.SelectedItem.ToString());
                appointment.CreateAppointment(branchId, doctorId, patientId, secretarySession.SecretaryId, dateTime);
                MessageBox.Show("Randevu oluşturuldu.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppointmentFormClear();
            }
        }

        private void txt_appointment_search_KeyPress(object sender, KeyPressEventArgs e) //Arama event'i
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_appointment_search.Text != null)
                {
                    dtGViewAppointment.DataSource = appointment.SearchAppointmentRecord(txt_appointment_search.Text);
                }
            }
        }
        private void dtGViewAppointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DGW'da çift tıklanan verinin ID'si alınıyor.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewAppointment.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    appointmentId = Convert.ToInt32(dtGViewAppointment.Rows[e.RowIndex].Cells[0].Value);                   
                }
            }
        }

        private void btn_appointment_delete_Click(object sender, EventArgs e) //Randevu silme event'i
        {
            if (appointmentId > 0)
            {
                DialogResult dialog = MessageBox.Show(appointmentId + " numaralı randevuyu iptal etmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (appointment.DeleteAppointmentRecord(appointmentId))
                    {
                        MessageBox.Show(appointmentId + " numaralı randevu iptal edildi.", "Bilgi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AppointmentFormClear();
                    }
                }
                else
                    MessageBox.Show("Randevu iptal etme işlemi iptal edildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("İptal etmek istediğiniz randevu için tablodan randevu seçiniz." +
                    "(Seçim işlemini randevu bilgisine çift tıklayarak yapabilirsiniz.)", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppointmentFormClear() //Formu temizler.
        {
            cmb_branch.Text = "";
            cmb_doctor.Text = "";
            cmb_patient.Text = "";
            dt_date.Value = DateTime.Today;
            appointmentId = 0;
            dtGViewAppointment.DataSource = appointment.GetAppointmentList();
        }

        #endregion

        #region Patient Tab View Code 
        private void btn_patient_save_Click(object sender, EventArgs e) //Hasta kaydetme event'i
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

        private void btn_patient_update_Click(object sender, EventArgs e) //Hasta güncelleme event'i
        {
            if (txt_patient_name.Text != "" && txt_patient_lastname.Text != "" &&
                txt_patient_email.Text != "" && txt_patient_phone.Text != "" && patientId > 0)
            {

                if (patient.UpdatePatientRecord(patientId, txt_patient_name.Text,
                    txt_patient_lastname.Text, txt_patient_phone.Text, txt_patient_email.Text))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    PatientFormClear();
                }
            }
        }

        private void btn_patient_delete_Click(object sender, EventArgs e) //Hasta silme event'i
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

        private void dtGViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DGW'da veriye çift tıklayınca txtbox'lara bilgiler yazılıyor.
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
        private void txt_patient_search_KeyPress(object sender, KeyPressEventArgs e) //Arama event'i
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_patient_search.Text != null)
                {
                    dtGViewPatient.DataSource = patient.SearchPatientRecord(txt_patient_search.Text);
                }
            }
        }

        private void PatientFormClear() //Formu temizler
        {
            patientId = 0;
            txt_patient_name.Text = "";
            txt_patient_lastname.Text = "";
            txt_patient_email.Text = "";
            txt_patient_phone.Text = "";
            dtGViewPatient.DataSource = patient.GetPatientsList();
        }
        #endregion

        #region Doctor Tab View Code
        private void btn_doctor_save_Click(object sender, EventArgs e) //Doktor kaydetme event'i
        {
            if (txt_doctor_name.Text != "" && txt_doctor_lastname.Text != "" &&
                txt_doctor_phone.Text != "" && txt_doctor_password.Text != "" && cmb_doctor_branch.SelectedItem != null)
            {
                int branchId = ((Branch)cmb_doctor_branch.SelectedItem).BranchId;

                if (doctor.AddDoctorRecord(txt_doctor_name.Text, txt_doctor_lastname.Text,
                    branchId, txt_doctor_phone.Text, txt_doctor_password.Text))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    DoctorFormClear();
                }
            }
        }

        private void dtGViewDoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DGW'da veriye çift tıklayınca txtbox ve cmbox'lara bilgiler yazılıyor.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewDoctor.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    doctorId = Convert.ToInt32(dtGViewDoctor.Rows[e.RowIndex].Cells[0].Value);
                    txt_doctor_name.Text = dtGViewDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_doctor_lastname.Text = dtGViewDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cmb_doctor_branch.SelectedItem = cmb_doctor_branch.Items[cmb_doctor_branch.FindStringExact(
                        dtGViewDoctor.Rows[e.RowIndex].Cells[3].Value.ToString())];
                    txt_doctor_phone.Text = dtGViewDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txt_doctor_password.Text = dtGViewDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }

        private void txt_doctor_search_KeyPress(object sender, KeyPressEventArgs e) //Arama event'i
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_doctor_search.Text != null)
                {
                    dtGViewDoctor.DataSource = doctor.SearchDoctorRecord(txt_doctor_search.Text);
                }
            }
        }
        private void btn_doctor_update_Click(object sender, EventArgs e) //Doktor güncelleme event'i
        {
            if (txt_doctor_name.Text != "" && txt_doctor_lastname.Text != "" &&
               txt_doctor_phone.Text != "" && txt_doctor_password.Text != "" && cmb_doctor_branch.SelectedItem != null && doctorId > 0)
            {
                int branchId = ((Branch)cmb_doctor_branch.SelectedItem).BranchId;

                if (doctor.UpdateDoctorRecord(doctorId, txt_doctor_name.Text,
                    txt_doctor_lastname.Text, branchId, txt_doctor_phone.Text, txt_doctor_password.Text))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    DoctorFormClear();
                }
            }
        }

        private void btn_doctor_delete_Click(object sender, EventArgs e) //Doktor silme event'i
        {
            if (doctorId > 0)
            {
                DialogResult dialog = MessageBox.Show(doctorId + " numaralı doktoru silmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (doctor.DeleteDoctorRecord(doctorId))
                    {
                        MessageBox.Show(doctorId + " numaralı doktor silindi.", "Bilgi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DoctorFormClear();
                    }
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Silmek istediğiniz veri için tablodan doktor seçiniz." +
                    "(Seçim işlemini doktor bilgisine çift tıklayarak yapabilirsiniz.)", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DoctorFormClear() //Formu temizler
        {
            doctorId = 0;
            txt_doctor_name.Text = "";
            txt_doctor_lastname.Text = "";
            txt_doctor_phone.Text = "";
            txt_doctor_password.Text = "";
            cmb_doctor_branch.Text = "";
            dtGViewDoctor.DataSource = doctor.GetDoktorsList();
        }
        #endregion

        #region Secretary Tab View Code
        private void btn_secreter_save_Click(object sender, EventArgs e) //Sekreter kaydetme event'i
        {
            if (txt_secreter_name.Text != "" && txt_secreter_lastname.Text != "" &&
                 txt_secreter_phone.Text != "")
            {

                if (secretary.AddSecretaryRecord(txt_secreter_name.Text, txt_secreter_lastname.Text,
                    txt_secreter_phone.Text, txt_secreter_password.Text))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    SecretaryFormClear();
                }
            }
        }

        private void txt_secreter_search_KeyPress(object sender, KeyPressEventArgs e) //Arama event'i
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txt_secreter_search.Text != null)
                {
                    dtGViewSecreter.DataSource = secretary.SearchSecretaryRecord(txt_secreter_search.Text);
                }
            }
        }

        private void dtGViewSecreter_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DGW'da veriye çift tıklayınca txtbox'lara bilgiler yazılıyor.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dtGViewSecreter.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    secretaryId = Convert.ToInt32(dtGViewSecreter.Rows[e.RowIndex].Cells[0].Value);
                    txt_secreter_name.Text = dtGViewSecreter.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_secreter_lastname.Text = dtGViewSecreter.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_secreter_phone.Text = dtGViewSecreter.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_secreter_password.Text = dtGViewSecreter.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void btn_secreter_update_Click(object sender, EventArgs e) //Sekreter güncelleme event'i
        {
            if (txt_secreter_name.Text != "" && txt_secreter_lastname.Text != "" &&
                 txt_secreter_phone.Text != "" && txt_secreter_password.Text != "" &&secretaryId > 0)
            {

                if (secretary.UpdateSecretaryRecord(secretaryId, txt_secreter_name.Text,
                    txt_secreter_lastname.Text, txt_secreter_phone.Text, txt_secreter_password.Text))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    SecretaryFormClear();
                }
            }
        }

        private void btn_secreter_delete_Click(object sender, EventArgs e) //Sekreter silme event'i
        {
            if (secretaryId > 0)
            {
                DialogResult dialog = MessageBox.Show(secretaryId + " numaralı sekreteri silmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (secretary.DeleteSecretaryRecord(secretaryId))
                    {
                        MessageBox.Show(secretaryId + " numaralı sekreter silindi.", "Bilgi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SecretaryFormClear();
                    }
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Silmek istediğiniz veri için tablodan sekreter seçiniz." +
                    "(Seçim işlemini sekreter bilgisine çift tıklayarak yapabilirsiniz.)", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SecretaryFormClear() //Formu temizler
        {
            secretaryId = 0;
            txt_secreter_name.Text = "";
            txt_secreter_lastname.Text = "";
            txt_secreter_phone.Text = "";
            txt_secreter_password.Text = "";
            dtGViewSecreter.DataSource = secretary.GetSecretarysList();
        }
        #endregion

        private void GetStatistic()
        {
            chart_branch.DataSource = secretary.GetNumberofPatientsbyBranch();
            chart_branch.Series[0].XValueMember = "Branch";
            chart_branch.Series[0].YValueMembers = "Count";
            chart_branch.Invalidate();

            chart_doctor.DataSource = secretary.GetNumberofPatientsbyDoctor();
            chart_doctor.Series[0].XValueMember = "DName";
            chart_doctor.Series[0].YValueMembers = "Count";
            chart_doctor.Invalidate();
        }

    }
}
