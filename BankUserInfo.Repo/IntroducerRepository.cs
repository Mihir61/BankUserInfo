using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class IntroducerRepository : Repository<Introducer>
    {
        private BankUserInfoContext _context;
        public IntroducerRepository(BankUserInfoContext context) : base(context)
        {
            _context = context;
        }
    }
}
