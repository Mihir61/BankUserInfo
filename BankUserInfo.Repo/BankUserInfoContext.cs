using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class BankUserInfoContext : DbContext
    {
        public BankUserInfoContext() : base("BankConString")
        {

        }
        public DbSet<Member> Menbers { get; set; }
        public DbSet<NomineeInfo> NomineeInfo { get; set; }
    }
}
