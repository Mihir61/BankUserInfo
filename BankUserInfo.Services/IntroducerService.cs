using BankUserInfo.Entities;
using BankUserInfo.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Services
{
    public class IntroducerService
    {
        private BankUserInfoContext _context;
        private IntroducerUnitOfWork _introducerUnitOfWork;
        public IntroducerService()
        {
            _context =new BankUserInfoContext();
            _introducerUnitOfWork = new IntroducerUnitOfWork(_context);
        }
        public IEnumerable<Introducer> GetIntroducer()
        {
            return _introducerUnitOfWork.introducerRepository.GetAll();
        }
        public Introducer GetIntroducerById(int id)
        {
            return _introducerUnitOfWork.introducerRepository.GetById(id);
        }
        public void AddIntroducer(Introducer  introducer)
        {
            var Introducer = new Introducer()
            {
               Name = introducer.Name,
               PhoneNo = introducer.PhoneNo,
               MemNo = introducer.MemNo
            };
            _introducerUnitOfWork.introducerRepository.Add(introducer);
            _introducerUnitOfWork.Save();
        }
        public void EditIntroducer(Introducer introducer)
        {
            var Introducer = GetIntroducerById(introducer.Id);
            if (Introducer != null)
            {
                Introducer.Name = introducer.Name;
                Introducer.MemNo = introducer.MemNo;
                Introducer.PhoneNo = introducer.PhoneNo;
                _introducerUnitOfWork.introducerRepository.Update(introducer);
                _introducerUnitOfWork.Save();
            }

        }
        public void DeleteNomineeInfo(int id)
        {
            _introducerUnitOfWork.introducerRepository.DeleteById(id);
        }
    }
}
