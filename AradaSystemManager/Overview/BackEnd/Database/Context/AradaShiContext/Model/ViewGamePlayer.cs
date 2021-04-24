using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGamePlayer
    {
        public long Id { get; set; }
        public long? GameId { get; set; }
        public DateTime GameSchedule { get; set; }
        public string TelegramId { get; set; }
        public string Status { get; set; }
        public string GameStatus { get; set; }
        public DateTime? EndedDate { get; set; }
        public string LastQuestion { get; set; }
        public string Type { get; set; }
        public int? MinPlayer { get; set; }
        public long Creator { get; set; }
        public bool IsHagerUsed { get; set; }
        public string Firstname { get; set; }
        public long? PlayerId { get; set; }
        public int? LastQuestionNumber { get; set; }
        public bool? IsQuestionAnswered { get; set; }
        public string GameScheduleEt { get; set; }
        public decimal GameFee { get; set; }
        public string GameGenre { get; set; }
    }
}
