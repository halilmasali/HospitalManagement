using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Secretary //Sekreter tablosu prop'ları.
    {
        public int SecretaryId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Password { get; set; }

        public Secretary(int SecretaryId, string Name, string LastName, string PhoneNum, string Password) //Sekreter classı constructor'ı.
        {
            this.SecretaryId = SecretaryId;
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNum = PhoneNum;
            this.Password = Password;
        }
    }
}
