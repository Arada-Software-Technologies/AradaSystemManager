using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameRevenuLog
    {
        public long Id { get; set; }
        public long? GameId { get; set; }
        public decimal? ServiceCharge { get; set; }
        public double? ServiceChargeRate { get; set; }
        public double? VatRate { get; set; }
        public decimal? Vat { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Game Game { get; set; }
    }
}
