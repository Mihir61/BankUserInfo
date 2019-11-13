using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Entities
{
    public class Introducer : Entity
    {
        [DisplayName("Introducer Name")]
        public string Name { get; set; }
        public int MemNo { get; set; }
        public string PhoneNo { get; set; }

        public virtual Member Member { get; set; }
        [ForeignKey("MemberId")]
        public int MemberId { get; set; }
    }
}
