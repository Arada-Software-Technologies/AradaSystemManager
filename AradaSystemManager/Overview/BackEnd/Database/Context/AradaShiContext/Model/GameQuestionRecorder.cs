using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameQuestionRecorder
    {
        public long Id { get; set; }
        public long GameId { get; set; }
        public string QuestionId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual Game Game { get; set; }
    }
}
