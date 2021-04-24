using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewClientInfo
    {
        public long Id { get; set; }
        public string TelegramId { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
