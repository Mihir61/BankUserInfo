using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Entities
{
    public class AccountInfo : Entity
    {
        public decimal SavingAcc { get; set; }
        public decimal ShareAcc { get; set; }
        public decimal HDSAcc { get; set; }
        public decimal DPSAcc { get; set; }
        public decimal FDRAcc { get; set; }
    }
}
