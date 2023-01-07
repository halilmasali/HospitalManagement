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
        public List<Doctor> getDoctorsByBranch(int branchId)
        {
            List<Doctor> list = new List<Doctor>();
            List<Doctor> doctors = DoctorControl.getDoctors();
            foreach (Doctor item in doctors)
            {
                if (item.BranchId == branchId)
                {
                    list.Add(item);
                }
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

        public void CreateAppointment(int branchId, int doctorId, int patientId,int secreteryId, DateTime dateTime)
        {
            OleDbCommand sqlCommand = Database.SqlCommand(
                "insert into Appointment (DoctorId,SecretaryId,PatientId,BranchId,[DateTime]) " +
                "values(@DoctorId,@SecretaryId,@PatientId,@BranchId,@DateTime)");
            sqlCommand.Parameters.AddWithValue("@DoctorId", doctorId);
            sqlCommand.Parameters.AddWithValue("@SecretaryId", secreteryId);
            sqlCommand.Parameters.AddWithValue("@PatientId", patientId);
            sqlCommand.Parameters.AddWithValue("@BranchId", branchId);
            sqlCommand.Parameters.AddWithValue("@DateTime", dateTime);            
            sqlCommand.ExecuteNonQuery();
        }



    }
}
