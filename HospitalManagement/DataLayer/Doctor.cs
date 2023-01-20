
namespace HospitalManagement.DataLayer
{
    class Doctor //Doktor tablosu prop'ları.
    {
        public int DoctorId { get; }
        public string DName { get; set; }
        public string DLastName { get; set; }
        public int BranchId { get; set; }
        public string PhoneNum { get; set; }
        public string DPassword { get; set; }


        public Doctor(int DoctorId, string DName, string DLastName, int BranchId, string PhoneNum, string DPassword) //Doktor classı constructor'ı.
        {
            this.DoctorId = DoctorId;
            this.DName = DName;
            this.DLastName = DLastName;
            this.BranchId = BranchId;
            this.PhoneNum = PhoneNum;
            this.DPassword = DPassword;
        }

        public override string ToString() //override edilmiş toString() methodu.
        {
            return DName + " " + DLastName;
        }
    }
}
