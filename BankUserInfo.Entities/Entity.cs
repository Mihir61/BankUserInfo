using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        [DisplayName("Birth Date")]
        public DateTime Birthdate { get; set; }
        public string Image { get; set; }
        public string BloodGroup { get; set; }
        [DisplayName("NID Number")]
        public decimal NIDNumber { get; set; }
        [DisplayName("Birth Regi Number")]
        public decimal BirthRegiNum { get; set; }
        [DisplayName("Passport Number")]
        public decimal PassportNumber { get; set; }
    }
}
