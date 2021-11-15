using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBAL1
{
    class PayRoll
    {
        public int EmpId { get; set; }
        public int BankAccountNo { get; set; }
        public int ProvidentFundNo { get; set; }
        public int BasicPay { get; set; }
        public int HRA { get; set; }
        public int MedicalAllowance { get; set; }
        public int Tax { get; set; }
        public int Bonus { get; set; }
        public int GrossPay { get; set; }
        public int NoOfWorkDays { get; set; }
    }
}
