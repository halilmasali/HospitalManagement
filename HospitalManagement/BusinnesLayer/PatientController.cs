using HospitalManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BusinnesLayer
{
    class PatientController
    {
        public static List<Patient> getPatients()
        {
            OleDbCommand sqlCommand = Database.SqlCommand("select * from Patient");
            OleDbDataReader dataReader = sqlCommand.ExecuteReader();
            List<Patient> patients = new List<Patient>();

            while (dataReader.Read())
            {
                Patient item = new Patient(
                    Convert.ToInt32(dataReader[0]),
                    dataReader[1].ToString(),
                    dataReader[2].ToString(),
                    dataReader[3].ToString(),
                    dataReader[4].ToString());
                patients.Add(item);
            }
            dataReader.Close();
            return patients;
        }

        public bool AddPatientRecord(string name, string lastname, string phoneNum, string email)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "insert into Patient (PName,PLastName,PhoneNumber,Email,[RecordDate]) " +
                    "values(@PName,@PLastName,@PhoneNumber,@Email,@RecordDate)");
                sqlCommand.Parameters.AddWithValue("@PName", name);
                sqlCommand.Parameters.AddWithValue("@PLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@RecordDate", DateTime.Today);
                if (sqlCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (OleDbException exception)
            {                
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return false;
            }
            return false;
        }

        public bool UpdatePatientRecord(int id,string name, string lastname, string phoneNum, string email)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "UPDATE Patient SET PName = @PName,PLastName = @PLastName," +
                    " PhoneNumber = @PhoneNumber, Email = @Email where PatientId = @PatientId");
                sqlCommand.Parameters.AddWithValue("@PName", name);
                sqlCommand.Parameters.AddWithValue("@PLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@PatientId", id);
                if (sqlCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return false;
            }
            return false;
        }

        public DataTable GetPatientsList()
        {
            OleDbCommand sqlCommand = Database.SqlCommand("select * from Patient");               
            DataTable table = new DataTable();
            table.Load(sqlCommand.ExecuteReader());
            return table;
        }

    }
}
