using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Doctor
    {
        public int DoctorId { get; }
        public string DName { get; set; }
        public string DLastName { get; set; }
        public int BranchId { get; set; }
        public string PhoneNum { get; set; }


        public Doctor(int DoctorId, string DName, string DLastName, int BranchId, string PhoneNum)
        {
            this.DoctorId = DoctorId;
            this.DName = DName;
            this.DLastName = DLastName;
            this.BranchId = BranchId;
            this.PhoneNum = PhoneNum;
        }

        public override string ToString()
        {
            return DName + " " + DLastName;
        }
    }
}
