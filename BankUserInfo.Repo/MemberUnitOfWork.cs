using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class MemberUnitOfWork : IDisposable
    {
        private BankUserInfoContext _context;
        private MemberRepository _memberRepository;

        public MemberUnitOfWork(BankUserInfoContext context)
        {
            _context = context;
            _memberRepository = new MemberRepository(_context);
        }
        public MemberRepository memberRepository
        {
            get
            {
                return _memberRepository;
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
