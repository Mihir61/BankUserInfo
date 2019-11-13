using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class NomineeInfoUnitOfWork : IDisposable
    {
        private BankUserInfoContext _context;
        private NomineeInfoRepositoty _nomineeInfoRepositoty;

        public NomineeInfoUnitOfWork(BankUserInfoContext context)
        {
            _context = context;
            _nomineeInfoRepositoty = new NomineeInfoRepositoty(_context);
        }
        public NomineeInfoRepositoty nomineeInfoRepositoty
        {
            get
            {
                return _nomineeInfoRepositoty;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
