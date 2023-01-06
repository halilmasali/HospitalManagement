using HospitalManagement.DataLayer;
using System;
using System.Collections.Generic;
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
    }
}
