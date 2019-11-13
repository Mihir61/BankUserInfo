using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Entities
{
    public class NomineeInfo :Entity
    {
        [Key]
        public int NomineeId { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string ContactNo { get; set; }
        public decimal BaseNo { get; set; }

        public virtual Member Member { get; set; }
        [ForeignKey("MemberId")]
        public int MemberId { get; set; }
    }
}
