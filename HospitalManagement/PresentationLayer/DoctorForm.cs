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
        int secretaryId = 0, patientId = 0, appointmentId = 0, doctorId = 0;
        AppointmentDetailsController appointmentDetails;
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
                    lbl_patientName.Text = dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lbl_patientLastName.Text = dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                    lbl_patientPhone.Text = dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                    lbl_patientEmail.Text = dtGViewAppointmentDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }
    }
}
