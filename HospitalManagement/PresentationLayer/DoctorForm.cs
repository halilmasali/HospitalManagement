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
    }
}
