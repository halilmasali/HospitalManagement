using HospitalManagement.DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BusinnesLayer
{
    class SecretaryControl
    {
        int secreteryId = 1;
        public ArrayList getDoctorsForCmb(int branchId)
        {
            ArrayList list = new ArrayList();
            List<Doctor> doctors = DoctorControl.getDoctors();
            foreach (Doctor item in doctors)
            {
                if (item.BranchId == branchId)
                {
                    list.Add(item.DoctorId + "-" + item.DName + " " + item.DLastName);
                }
            }
            return list;
        }

        public ArrayList getBranchsForCmb()
        {
            ArrayList list = new ArrayList();
            List<Branch> branchs = BranchControl.getBranchs();
            foreach (Branch item in branchs)
            {
                list.Add(item.BranchName);
            }
            return list;
        }

        public ArrayList getPatientsForCmb()
        {
            ArrayList list = new ArrayList();
            List<Patient> patients = PatientController.getPatients();
            foreach (Patient item in patients)
            {
                list.Add(item.PatientId + "-" + item.PName + " " + item.PLastName);
            }
            return list;
        }

        public int GetBranchIdFromName(string branchName)
        {
            OleDbCommand sqlCommand = Database.SqlCommand("select BranchId From Branch where Branch=@branch");
            sqlCommand.Parameters.AddWithValue("@branch", branchName);
            OleDbDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            return dataReader.GetInt32(0);
        }

        public void CreateAppointment(int branchId, int doctorId, int patientId, DateTime dateTime)
        {
            OleDbCommand sqlCommand = Database.SqlCommand(
                "insert into Appointment(DoctorId,SecretaryId,PatientId,BranchId,DateTime) " +
                "values(@DoctorId,@SecretaryId,@PatientId,@BranchId,@DateTime");
            sqlCommand.Parameters.AddWithValue("@DoctorId", doctorId);
            sqlCommand.Parameters.AddWithValue("@SecretaryId", secreteryId);
            sqlCommand.Parameters.AddWithValue("@BranchId", branchId);
            sqlCommand.Parameters.AddWithValue("@DateTime", dateTime);
            sqlCommand.Parameters.AddWithValue("@PatientId", patientId);
            sqlCommand.ExecuteReader();

        }



    }
}
