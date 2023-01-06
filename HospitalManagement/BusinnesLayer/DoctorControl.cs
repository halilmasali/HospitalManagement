using HospitalManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BusinnesLayer
{
    class DoctorControl
    {
        public static List<Doctor> getDoctors()
        {
            OleDbCommand sqlCommand = Database.SqlCommand("select * from Doctor");
            OleDbDataReader dataReader = sqlCommand.ExecuteReader();
            List<Doctor> doctors = new List<Doctor>();

            while (dataReader.Read())
            {
                Doctor item = new Doctor(
                    Convert.ToInt32(dataReader[0]),
                    dataReader[1].ToString(),
                    dataReader[2].ToString(),
                    Convert.ToInt32(dataReader[3]),
                    dataReader[4].ToString());
                doctors.Add(item);
            }
            dataReader.Close();
            return doctors;
        }
    }
}
