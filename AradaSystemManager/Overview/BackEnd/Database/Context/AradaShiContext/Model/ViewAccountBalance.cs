using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewAccountBalance
    {
        public string Phone { get; set; }
        public string TelegramId { get; set; }
        public decimal? Balance { get; set; }
    }
}
