using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewClientGame
    {
        public long Id { get; set; }
        public string TelegramId { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public DateTime GameSchedule { get; set; }
        public string GameScheduleEt { get; set; }
        public decimal GameFee { get; set; }
        public string Status { get; set; }
        public long Creator { get; set; }
        public string GameGenre { get; set; }
    }
}
