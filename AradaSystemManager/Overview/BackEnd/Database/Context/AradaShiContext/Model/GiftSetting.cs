using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GiftSetting
    {
        public GiftSetting()
        {
            GiftLogs = new HashSet<GiftLog>();
        }

        public long Id { get; set; }
        public string GiftMode { get; set; }
        public decimal? Amount { get; set; }
        public int? TotalGift { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int RemainingGift { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<GiftLog> GiftLogs { get; set; }
    }
}
