using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameGenre
    {
        public GameGenre()
        {
            GameAdmissionFees = new HashSet<GameAdmissionFee>();
            GameSettings = new HashSet<GameSetting>();
            GameplayAlgorithms = new HashSet<GameplayAlgorithm>();
            Games = new HashSet<Game>();
        }

        public string Id { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }

        public virtual ICollection<GameAdmissionFee> GameAdmissionFees { get; set; }
        public virtual ICollection<GameSetting> GameSettings { get; set; }
        public virtual ICollection<GameplayAlgorithm> GameplayAlgorithms { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
