using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GiftLog
    {
        public long Id { get; set; }
        public long? GiftId { get; set; }
        public long? ClientId { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual GiftSetting Gift { get; set; }
    }
}
