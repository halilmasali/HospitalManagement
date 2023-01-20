
namespace HospitalManagement.DataLayer
{
    class PatientRecord //RandevuDetay tablosu prop'ları.
    {
        public int RecordId { get; set; }
        public int AppointmentId { get; set; }
        public string Note { get; set; }       

        public PatientRecord(int RecordId, int AppointmentId, string Note) //RandevuDetay classı constructor'ı.
        {
            this.RecordId = RecordId;
            this.AppointmentId = AppointmentId;
            this.Note = Note;
        }
    }
}
