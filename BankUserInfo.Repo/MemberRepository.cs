using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
   public class MemberRepository : Repository<Member>
    {
        private BankUserInfoContext _context;
        public MemberRepository(BankUserInfoContext context) : base(context)
        {
            _context = context;
        }
    }
}

