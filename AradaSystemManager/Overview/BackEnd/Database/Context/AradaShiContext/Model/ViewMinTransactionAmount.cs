using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewMinTransactionAmount
    {
        public long Id { get; set; }
        public decimal? Amount { get; set; }
        public string TransactionType { get; set; }
        public string Bank { get; set; }
    }
}
