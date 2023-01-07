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
    class AppointmentController
    {
        public DataTable GetAppointmentList()
        {
            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT " +
                    "Appointment.AppointmentId AS [ID]," +
                    "Doctor.DName & ' ' & Doctor.DLastName AS [Doktor Adı]," +
                    "Patient.PName & ' ' & Patient.PLastName AS[Hasta Adı]," +
                    "Secretary.SName & ' ' & Secretary.SLastName AS[Sekreter Adı]," +
                    "Appointment.DateTime AS[Randevu Zamanı] " +
                    "FROM(((Appointment " +
                    "INNER JOIN Doctor ON Doctor.DoctorId = Appointment.DoctorId) " +
                    "INNER JOIN Patient ON Patient.PatientId = Appointment.PatientId) " +
                    "INNER JOIN Secretary ON Secretary.SecretaryId = Appointment.SecretaryId)");
                DataTable table = new DataTable();
                table.Load(sqlCommand.ExecuteReader());
                return table;
            }
            catch (OleDbException exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata :" + exception.Message);
                return null;
            }

            //SELECT Doctor.DName & ' ' & Doctor.DLastName AS[Doktor Adı], 
            //Patient.PName & ' ' & Patient.PLastName AS[Hasta Adı], 
            //Secretary.SName & ' ' & Secretary.SLastName AS[Sekreter Adı], 
            //Appointment.DateTime AS[Randevu Zamanı]
            //FROM(((Appointment
            //INNER JOIN Doctor ON Doctor.DoctorId = Appointment.DoctorId)
            //INNER JOIN Patient ON Patient.PatientId = Appointment.PatientId)
            //INNER JOIN Secretary ON Secretary.SecretaryId = Appointment.SecretaryId)
        }
    }
}
