using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GamePlayer
    {
        public long Id { get; set; }
        public long? GameId { get; set; }
        public long? PlayerId { get; set; }
        public string Status { get; set; }
        public string LastQuestion { get; set; }
        public bool IsReminderSent { get; set; }
        public bool IsHagerUsed { get; set; }
        public int? LastQuestionNumber { get; set; }
        public int? LastSelctedAnswer { get; set; }
        public bool? IsQuestionAnswered { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? EndedDate { get; set; }

        public virtual Game Game { get; set; }
        public virtual Question LastQuestionNavigation { get; set; }
        public virtual ClientInfo Player { get; set; }
    }
}
