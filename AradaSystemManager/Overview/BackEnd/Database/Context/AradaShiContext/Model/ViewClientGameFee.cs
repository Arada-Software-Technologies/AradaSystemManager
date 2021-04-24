using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewClientGameFee
    {
        public long ClientId { get; set; }
        public long WithdrawalId { get; set; }
        public long ClientAccount { get; set; }
        public string WithdrawalReason { get; set; }
        public string RefNumber { get; set; }
        public DateTime? WithdrawalDate { get; set; }
    }
}
