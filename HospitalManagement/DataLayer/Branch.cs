using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public Branch(int BranchId, string BranchName)
        {
            this.BranchId = BranchId;
            this.BranchName = BranchName;
        }

        public override string ToString()
        {
            return BranchName;
        }
    }
}
