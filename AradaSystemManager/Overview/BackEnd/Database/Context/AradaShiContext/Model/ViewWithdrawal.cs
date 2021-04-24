using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewWithdrawal
    {
        public long Id { get; set; }
        public long? ClientAccountId { get; set; }
        public decimal? Amount { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string RefNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? WithdrawalDate { get; set; }
    }
}
