using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Patient
    {
        public int PatientId { get; set; }
        public string PName { get; set; }
        public string PLastName { get; set; }
        public string PhoneNum { get; set; }
        public string RecordDate { get; set; }

        public Patient(int PatientId,string Name, string LastName, string PhoneNum,string RecordDate)
        {
            this.PatientId = PatientId;
            this.PName = Name;
            this.PLastName = LastName;
            this.PhoneNum = PhoneNum;
            this.RecordDate = RecordDate;
        }

        public override string ToString()
        {
            return PatientId + " " + PName + " " + PLastName;
        }
    }
}
