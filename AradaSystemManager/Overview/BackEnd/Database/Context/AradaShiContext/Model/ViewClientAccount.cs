using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewClientAccount
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public string TelegramId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
