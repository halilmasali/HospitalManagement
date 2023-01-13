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
                    dataReader[4].ToString(),
                    dataReader[5].ToString());
                doctors.Add(item);
            }
            dataReader.Close();
            return doctors;
        }

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

        public bool AddDoctorRecord(string name, string lastname, int branchId, string phoneNum, string password)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "INSERT INTO Doctor (DName,DLastName,BranchId,PhoneNumber,DPassword) " +
                    "VALUES(@DName,@DLastName,@BranchId,@PhoneNumber,@DPassword)");
                sqlCommand.Parameters.AddWithValue("@DName", name);
                sqlCommand.Parameters.AddWithValue("@DLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@BranchId", branchId);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);                
                sqlCommand.Parameters.AddWithValue("@DPassword", password);                
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

        public bool UpdateDoctorRecord(int id, string name, string lastname, int branchId, string phoneNum, string password)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "UPDATE Doctor SET DName = @DName,DLastName = @DLastName," +
                    " PhoneNumber = @PhoneNumber, BranchId = @BranchId, DPassword = @DPassword WHERE DoctorId = @DoctorId");
                sqlCommand.Parameters.AddWithValue("@PName", name);
                sqlCommand.Parameters.AddWithValue("@PLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                sqlCommand.Parameters.AddWithValue("@BranchId", branchId);
                sqlCommand.Parameters.AddWithValue("@DPassword", password);
                sqlCommand.Parameters.AddWithValue("@DoctorId", id);
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

        public bool DeleteDoctorRecord(int id)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("DELETE FROM Doctor WHERE DoctorId = @DoctorId");
                sqlCommand.Parameters.AddWithValue("@DoctorId", id);
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

        public DataTable SearchDoctorRecord(string searchValue)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT " +
                    "Doctor.DoctorId AS [Id], " +
                    "Doctor.DName AS [Doktor Adı], " +
                    "Doctor.DLastName AS [Doktor Soyadı], " +
                    "Branch.Branch AS [Branş]," +
                    "Doctor.PhoneNumber AS [Telefon Numarası]" +
                    "FROM(Doctor " +
                    "INNER JOIN Branch ON Doctor.BranchId = Branch.BranchId)" +
                    "WHERE DName + DLastName + PhoneNumber + Branch.Branch LIKE '%" + searchValue + "%'");
                DataTable table = new DataTable();
                table.Load(sqlCommand.ExecuteReader());
                return table;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return null;
            }
        }

        public DataTable GetDoktorsList()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT " +
                    "Doctor.DoctorId AS [Id], " +
                    "Doctor.DName AS [Doktor Adı], " +
                    "Doctor.DLastName AS [Doktor Soyadı], " +
                    "Branch.Branch AS [Branş]," +
                    "Doctor.PhoneNumber AS [Telefon Numarası]," +
                    "Doctor.DPassword AS [Şifre]" +
                    "FROM(Doctor " +
                    "INNER JOIN Branch ON Doctor.BranchId = Branch.BranchId)");
                DataTable table = new DataTable();
                table.Load(sqlCommand.ExecuteReader());
                return table;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return null;
            }
        }

        public bool DoctorAuth(string phone, string password)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT PhoneNumber,DPassword FROM Doctor");
                OleDbDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[0].ToString() == phone && dataReader[1].ToString() == password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return false;
            }
        }
    }
}
