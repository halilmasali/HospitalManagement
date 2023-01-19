using HospitalManagement.DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HospitalManagement.BusinnesLayer
{
    class SecretaryControl
    {
        private static int AuthCredential = 0;
        public bool AddSecretaryRecord(string name, string lastname, string phoneNum, string password) //Yeni sekreter kaydı ekler.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "INSERT INTO Secretary (SName,SLastName,PhoneNumber,SPassword) " +
                    "VALUES(@SName,@SLastName,@PhoneNumber, @SPassword)");
                //parametreler bağlanıyor.
                sqlCommand.Parameters.AddWithValue("@SName", name);
                sqlCommand.Parameters.AddWithValue("@SLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                sqlCommand.Parameters.AddWithValue("@SPassword", password);
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

        public bool UpdateSecretaryRecord(int id, string name, string lastname, string phoneNum, string password) //Sekreter kaydını günceller.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "UPDATE Secretary SET SName = @SName,SLastName = @SLastName, " +
                    "PhoneNumber = @PhoneNumber, " +
                    "SPassword = @SPassword " +
                    "WHERE SecretaryId = @SecretaryId");
                sqlCommand.Parameters.AddWithValue("@SName", name);
                sqlCommand.Parameters.AddWithValue("@SLastName", lastname);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                sqlCommand.Parameters.AddWithValue("@SPassword", password);
                sqlCommand.Parameters.AddWithValue("@SecretaryId", id);
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

        public bool DeleteSecretaryRecord(int id) //Sekreter kaydını siler.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("DELETE FROM Secretary WHERE SecretaryId = @SecretaryId");
                sqlCommand.Parameters.AddWithValue("@SecretaryId", id);
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

        public DataTable SearchSecretaryRecord(string searchValue) //Arama sorgusu sonucu oluşan değerleri datatable olarak return eder.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT " +
                    "SecretaryId AS [ID], " +
                    "SName AS [Sekreter Adı], " +
                    "SLastName AS [Sekreter Soyadı], " +
                    "PhoneNumber AS [Telefon Numarası], " +
                    "SPassword AS [Şifre]" +
                    "FROM Secretary " +
                    "WHERE SName + SLastName + PhoneNumber LIKE '%" + searchValue + "%'");
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

        public DataTable GetSecretarysList() //Sekreter verisini datatable olarak geriye döndürür.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT " +
                    "SecretaryId AS [ID], " +
                    "SName AS [Sekreter Adı], " +
                    "SLastName AS [Sekreter Soyadı], " +
                    "PhoneNumber AS [Telefon Numarası], " +
                    "SPassword AS [Şifre]" +
                    "FROM Secretary");
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

        public bool SecretaryAuth(string phone, string password) //Sekreter girşi için authentication yapar.
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("SELECT PhoneNumber,SPassword,SecretaryId FROM Secretary");
                OleDbDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[0].ToString() == phone && dataReader[1].ToString() == password)
                    {
                        AuthCredential = Convert.ToInt32(dataReader[2]);
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
        //Branşa göre hasta sayısı
        public DataTable GetNumberofPatientsbyBranch()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT Branch.Branch, COUNT(*) AS [Count] " +
                    "FROM( Appointment " +
                    "INNER JOIN Branch ON Branch.BranchId = Appointment.BranchId) " +
                    "GROUP BY Branch.Branch");
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
        //Doktora göre hasta sayısı
        public DataTable GetNumberofPatientsbyDoctor()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                "SELECT Doctor.DName & ' ' & Doctor.DLastName AS [Doktor Adı], COUNT(*) as [Count] " +
                "FROM( Appointment " +
                "INNER JOIN Doctor ON Doctor.DoctorId = Appointment.DoctorId) " +
                "GROUP BY Doctor.DName & ' ' & Doctor.DLastName");
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
        //Açılan sekreter oturumunun bilgisini geriye göndürür.
        public Secretary GetSecretarySession()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT * FROM Secretary " +
                    "WHERE SecretaryId = @SecretaryId");
                sqlCommand.Parameters.AddWithValue("@SecretaryId", AuthCredential);
                OleDbDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                Secretary secretary = new Secretary(
                    Convert.ToInt32(dataReader[0]),
                    dataReader[1].ToString(),
                    dataReader[2].ToString(),
                    dataReader[3].ToString(),
                    dataReader[4].ToString());
                dataReader.Close();
                return secretary;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return null;
            }
        }
    }
}
