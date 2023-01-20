using HospitalManagement.DataLayer;
using System;
using System.Data;
using System.Data.OleDb;

namespace HospitalManagement.BusinnesLayer
{
    class AppointmentController
    {

        //Randevu tablosunu geriye döndürür
        public DataTable GetAppointmentList()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT " +
                    "Appointment.AppointmentId AS [ID]," +
                    "Doctor.DName & ' ' & Doctor.DLastName AS [Doktor Adı]," +
                    "Patient.PName & ' ' & Patient.PLastName AS [Hasta Adı]," +
                    "Branch.Branch AS [Bölüm]," +
                    "Secretary.SName & ' ' & Secretary.SLastName AS [Sekreter Adı]," +
                    "Appointment.DateTime AS[Randevu Zamanı] " +
                    "FROM((((Appointment " +
                    "INNER JOIN Doctor ON Doctor.DoctorId = Appointment.DoctorId) " +
                    "INNER JOIN Patient ON Patient.PatientId = Appointment.PatientId) " +
                    "INNER JOIN Secretary ON Secretary.SecretaryId = Appointment.SecretaryId) " +
                    "INNER JOIN Branch ON Branch.BranchId = Appointment.BranchId)");
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

        // Arama sorgusu sonucu oluşan değerleri datatable olarak return eder.
        public DataTable SearchAppointmentRecord(string searchValue)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT " +
                    "Appointment.AppointmentId AS [ID]," +
                    "Doctor.DName & ' ' & Doctor.DLastName AS [Doktor Adı]," +
                    "Patient.PName & ' ' & Patient.PLastName AS [Hasta Adı]," +
                    "Branch.Branch AS [Bölüm]," +
                    "Secretary.SName & ' ' & Secretary.SLastName AS [Sekreter Adı]," +
                    "Appointment.DateTime AS[Randevu Zamanı] " +
                    "FROM((((Appointment " +
                    "INNER JOIN Doctor ON Doctor.DoctorId = Appointment.DoctorId) " +
                    "INNER JOIN Patient ON Patient.PatientId = Appointment.PatientId) " +
                    "INNER JOIN Secretary ON Secretary.SecretaryId = Appointment.SecretaryId) " +
                    "INNER JOIN Branch ON Branch.BranchId = Appointment.BranchId)" +
                    "WHERE Doctor.DName + Doctor.DLastName + Patient.PName + Patient.PLastName +" +
                    "Branch.Branch + Secretary.SName + Secretary.SLastName LIKE '%" + searchValue + "%'");
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

        //duyuru silme
        public bool DeleteAppointmentRecord(int id)
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand("DELETE FROM Appointment WHERE AppointmentId = @AppointmentId");
                sqlCommand.Parameters.AddWithValue("@AppointmentId", id);
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

        //yeni duyuru ekleme
        public void CreateAppointment(int branchId, int doctorId, int patientId, int secreteryId, DateTime dateTime)
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
