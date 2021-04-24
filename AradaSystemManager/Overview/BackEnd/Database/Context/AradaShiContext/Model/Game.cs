using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Game
    {
        public Game()
        {
            GamePlayers = new HashSet<GamePlayer>();
            GameQuestionRecorders = new HashSet<GameQuestionRecorder>();
            GameRevenuLogs = new HashSet<GameRevenuLog>();
        }

        public long Id { get; set; }
        public string GameGenre { get; set; }
        public string GameType { get; set; }
        public string Status { get; set; }
        public long Creator { get; set; }
        public DateTime GameSchedule { get; set; }
        public string GameScheduleEt { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal GameFee { get; set; }
        public int? TotalQuestions { get; set; }
        public long? AssignedAlgorithm { get; set; }
        public bool? IsNumberOfQuestionCustom { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual GameplayAlgorithm AssignedAlgorithmNavigation { get; set; }
        public virtual ClientInfo CreatorNavigation { get; set; }
        public virtual GameGenre GameGenreNavigation { get; set; }
        public virtual GameType GameTypeNavigation { get; set; }
        public virtual ICollection<GamePlayer> GamePlayers { get; set; }
        public virtual ICollection<GameQuestionRecorder> GameQuestionRecorders { get; set; }
        public virtual ICollection<GameRevenuLog> GameRevenuLogs { get; set; }
    }
}
