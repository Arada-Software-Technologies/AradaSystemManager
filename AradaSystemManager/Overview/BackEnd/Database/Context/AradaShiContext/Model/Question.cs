using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Question
    {
        public Question()
        {
            GamePlayers = new HashSet<GamePlayer>();
            QuestionChoises = new HashSet<QuestionChoise>();
        }

        public string Id { get; set; }
        public int? AttachmentId { get; set; }
        public string GenreId { get; set; }
        public string QuestionTypeId { get; set; }
        public string Question1 { get; set; }
        public string DifficultyLevel { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public string Source { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string AttachmentUrl { get; set; }

        public virtual ICollection<GamePlayer> GamePlayers { get; set; }
        public virtual ICollection<QuestionChoise> QuestionChoises { get; set; }
    }
}
