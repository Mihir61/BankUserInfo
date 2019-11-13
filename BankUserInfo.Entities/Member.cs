using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Entities
{
    public class Member : AccountInfo
    {
        public int MemberBaseId { get; set; }
        [DisplayName("Member Name")]
        public string MemberName { get; set; }
        public string MemberNo { get; set; }
        public string MobileNo { get; set; }
        [DisplayName("Father Name")]
        public string FatherName { get; set; }
        public string FMemberNo { get; set; }
        [DisplayName("Mother Name")]
        public string MotherName { get; set; }
        public string MMemberNo { get; set; }
        [DisplayName("Spouse Name")]
        public string SpouseName { get; set; }
        public string SMemberNo { get; set; }
        [DisplayName("Present Address")]
        public string PresentAddress { get; set; }
        [DisplayName("Permanent Addres")]
        public string PermanentAddress { get; set; }
        [DisplayName("Office Address")]
        public string OfficeAddress { get; set; }

    }
}
