using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Bank
    {
        public Bank()
        {
            BankSettings = new HashSet<BankSetting>();
            MinimumTransactionAmounts = new HashSet<MinimumTransactionAmount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BankSetting> BankSettings { get; set; }
        public virtual ICollection<MinimumTransactionAmount> MinimumTransactionAmounts { get; set; }
    }
}
