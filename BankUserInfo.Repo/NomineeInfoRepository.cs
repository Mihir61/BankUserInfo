using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class NomineeInfoRepositoty : Repository<NomineeInfo>
    {
        private BankUserInfoContext _context;
        public NomineeInfoRepositoty(BankUserInfoContext context) : base(context)
        {
            _context = context;
        }
    }
}
