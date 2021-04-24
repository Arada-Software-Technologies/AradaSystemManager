using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class MinimumTransactionAmount
    {
        public long Id { get; set; }
        public decimal? Amount { get; set; }
        public int? Bank { get; set; }
        public string TransactionType { get; set; }

        public virtual Bank BankNavigation { get; set; }
    }
}
