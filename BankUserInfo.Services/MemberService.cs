using BankUserInfo.Entities;
using BankUserInfo.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Services
{
    public class MemberService
    {
        private BankUserInfoContext _context;
        private MemberUnitOfWork _memberUnitOfWork;
        public MemberService()
        {
            _context = new BankUserInfoContext();
            _memberUnitOfWork = new MemberUnitOfWork(_context);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _memberUnitOfWork.memberRepository.GetAll();
        }
        public Member GetMemberById(int id)
        {
            return _memberUnitOfWork.memberRepository.GetById(id);
        }
        public void AddMember(Member member)
        {
            var Member = new Member()
            {
                MemberBaseId = member.MemberBaseId,
                MemberName = member.MemberName,
                MemberNo = member.MemberNo,
                MobileNo =member.MobileNo,
                BloodGroup = member.BloodGroup,
                Birthdate = member.Birthdate,
                Image = member.Image,
                FatherName =member.FatherName,
                FMemberNo = member.FMemberNo,
                MotherName = member.MMemberNo,
                MMemberNo = member.MMemberNo,
                SpouseName = member.SpouseName,
                PresentAddress = member.PresentAddress,
                PermanentAddress = member.PermanentAddress,
                OfficeAddress = member.OfficeAddress,
                NIDNumber = member.NIDNumber,
                PassportNumber = member.PassportNumber,
                BirthRegiNum =member.BirthRegiNum,
                SavingAcc = member.SavingAcc,
                ShareAcc = member.ShareAcc,
                HDSAcc = member.HDSAcc,
                FDRAcc = member.FDRAcc,
                DPSAcc =member.DPSAcc,
            };
            _memberUnitOfWork.memberRepository.Add(member);
            _memberUnitOfWork.Save();
        }
        public void EditMember(Member member)
        {
            var Member = GetMemberById(member.Id);
            if (Member != null)
            {
                Member.MemberBaseId = member.MemberBaseId;
                Member.MemberName = member.MemberName;
                Member.MemberNo = member.MemberNo;
                Member.MobileNo = member.MobileNo;
                Member.BloodGroup = member.BloodGroup;
                Member.Birthdate = member.Birthdate;
                Member.Image = member.Image;
                Member.FatherName = member.FatherName;
                Member.FMemberNo = member.FMemberNo;
                Member.MotherName = member.MMemberNo;
                Member.MMemberNo = member.MMemberNo;
                Member.SpouseName = member.SpouseName;
                Member.PresentAddress = member.PresentAddress;
                Member.PermanentAddress = member.PermanentAddress;
                Member.OfficeAddress = member.OfficeAddress;
                Member.NIDNumber = member.NIDNumber;
                Member.PassportNumber = member.PassportNumber;
                Member.BirthRegiNum = member.BirthRegiNum;
                Member.SavingAcc = member.SavingAcc;
                Member.ShareAcc = member.ShareAcc;
                Member.HDSAcc = member.HDSAcc;
                Member.FDRAcc = member.FDRAcc;
                Member.DPSAcc = member.DPSAcc;
                _memberUnitOfWork.memberRepository.Update(member);
                _memberUnitOfWork.Save();
            }

        }
        public void DeleteMember(int id)
        {
            _memberUnitOfWork.memberRepository.DeleteById(id);
        }

    }
}
