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
        BranchControl branch;
        private void Form1_Load(object sender, EventArgs e)
        {            
            secretary = new SecretaryControl();
            cmb_branch.Items.AddRange(BranchControl.getBranchs().ToArray());
            //cmb_branch.Items.AddRange(secretary.getBranchsForCmb().ToArray());
            cmb_patient.Items.AddRange(secretary.getPatientsForCmb().ToArray());
        }

        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb_doctor.Text = "";
            //cmb_doctor.Items.Clear();
            //if (cmb_branch.SelectedItem != null)
            //{
            //    int branchID = secretary.GetBranchIdFromName(cmb_branch.SelectedItem.ToString());
            //    cmb_doctor.Items.AddRange(secretary.getDoctorsForCmb(branchID).ToArray());
            //    cmb_doctor.Enabled = true;
            //}
            MessageBox.Show(((Branch)cmb_branch.SelectedItem).BranchName);
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            //int branch = cmb_branch.SelectedIndex.ToString().Split('-')[0];
        }
    }
}
