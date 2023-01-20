
namespace HospitalManagement.DataLayer
{
    class Appointment //Randevu tablosu prop'ları.
    {
        public int AppointmentId { get; }
        public int DoctorId { get; set; }
        public int SecretaryId { get; set; }
        public int PatientId { get; set; }
        public int BranchId { get; set; }

        public Appointment(int DoctorId, int SecretaryId, int PatientId,int BranchId) //Randevu classı constructor'ı.
        {
            this.DoctorId = DoctorId;
            this.SecretaryId = SecretaryId;
            this.PatientId = PatientId;
            this.BranchId = BranchId;
        }
    }
}
