using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class SouqServiceFeeLog
    {
        public long Id { get; set; }
        public int? SouqId { get; set; }
        public long? ClientId { get; set; }
        public decimal? ServiceFee { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual Souq Souq { get; set; }
    }
}
