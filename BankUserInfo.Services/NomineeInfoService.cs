using BankUserInfo.Entities;
using BankUserInfo.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Services
{
    public class NomineeInfoService
    {
        private BankUserInfoContext _context;
        private NomineeInfoUnitOfWork _nomineeInfoUnitOfWork;
        public NomineeInfoService()
        {
            _context = new BankUserInfoContext();
            _nomineeInfoUnitOfWork = new NomineeInfoUnitOfWork(_context);
        }

        public IEnumerable<NomineeInfo> GetNominee()
        {
            return _nomineeInfoUnitOfWork.nomineeInfoRepositoty.GetAll();
        }
        public NomineeInfo GetNomineeInfoById(int id)
        {
            return _nomineeInfoUnitOfWork.nomineeInfoRepositoty.GetById(id);
        }
        public void AddNominee(NomineeInfo nominee)
        {
            var Nominee = new NomineeInfo()
            {
                Name = nominee.Name,
                Relation = nominee.Relation,
                BaseNo = nominee.BaseNo,
                ContactNo = nominee.ContactNo,
                NIDNumber = nominee.NIDNumber,
                BirthRegiNum = nominee.BirthRegiNum,
                Image = nominee.Image
            };
            _nomineeInfoUnitOfWork.nomineeInfoRepositoty.Add(nominee);
            _nomineeInfoUnitOfWork.Save();
        }
        public void EditNomineeInfo(NomineeInfo nominee)
        {
            var Nominee = GetNomineeInfoById(nominee.Id);
            if (Nominee != null)
            {
                Nominee.Name = nominee.Name;
                Nominee.Relation = nominee.Relation;
                Nominee.BaseNo = nominee.BaseNo;
                Nominee.ContactNo = nominee.ContactNo;
                Nominee.NIDNumber = nominee.NIDNumber;
                Nominee.BirthRegiNum = nominee.BirthRegiNum;
                Nominee.Image = nominee.Image;


                _nomineeInfoUnitOfWork.nomineeInfoRepositoty.Update(nominee);
                _nomineeInfoUnitOfWork.Save();
            }

        }
        public void DeleteNomineeInfo(int id)
        {
            _nomineeInfoUnitOfWork.nomineeInfoRepositoty.DeleteById(id);
        }

    }
}

