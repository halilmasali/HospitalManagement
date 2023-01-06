using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class PatientRecord
    {
        public int RecordId { get; }
        public int AppointmentId { get; set; }
        public string Note { get; set; }       

        public PatientRecord(int AppointmentId, string Note)
        {
            this.AppointmentId = AppointmentId;
            this.Note = Note;
        }
    }
}
