using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewDeposit
    {
        public long Id { get; set; }
        public long? ClientAccountId { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string BankId { get; set; }
        public string TtNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DepositDate { get; set; }
    }
}
