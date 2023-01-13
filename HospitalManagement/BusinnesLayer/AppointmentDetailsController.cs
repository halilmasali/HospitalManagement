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
    class AppointmentDetailsController
    {
        public DataTable GetAppointmentDetailsList()
        {

            try
            {
                OleDbCommand sqlCommand = Database.SqlCommand(
                    "SELECT " +
                    "Appointment.AppointmentId AS [Randevu ID]," +
                    "Patient.PName & ' ' & Patient.PLastName AS [Hasta Adı]," +
                    "Appointment.DateTime AS[Randevu Zamanı] " +
                    "FROM(Appointment " +
                    "INNER JOIN Patient ON Appointment.PatientId = Patient.PatientId)");
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
    }
}
