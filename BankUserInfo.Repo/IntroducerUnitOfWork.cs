using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class IntroducerUnitOfWork : IDisposable
    {
        private BankUserInfoContext _context;
        private IntroducerRepository _introducerRepository  ;

        public IntroducerUnitOfWork(BankUserInfoContext context)
        {
            _context = context;
            _introducerRepository = new IntroducerRepository(_context);
        }
        public IntroducerRepository introducerRepository
        {
            get
            {
                return _introducerRepository;
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
