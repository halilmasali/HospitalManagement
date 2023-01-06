using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Appointment
    {
        public int AppointmentId { get; }
        public int DoctorId { get; set; }
        public int SecretaryId { get; set; }
        public int PatientId { get; set; }
        public int BranchId { get; set; }

        public Appointment(int DoctorId, int SecretaryId, int PatientId,int BranchId)
        {
            this.DoctorId = DoctorId;
            this.SecretaryId = SecretaryId;
            this.PatientId = PatientId;
            this.BranchId = BranchId;
        }
    }
}
