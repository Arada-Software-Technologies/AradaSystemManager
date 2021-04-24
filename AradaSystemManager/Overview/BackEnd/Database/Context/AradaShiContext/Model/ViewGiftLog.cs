using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGiftLog
    {
        public long Id { get; set; }
        public long? GiftId { get; set; }
        public long? ClientId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string GiftMode { get; set; }
        public string Status { get; set; }
    }
}
