using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameType
    {
        public GameType()
        {
            Games = new HashSet<Game>();
            MinimumGamePlayers = new HashSet<MinimumGamePlayer>();
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<MinimumGamePlayer> MinimumGamePlayers { get; set; }
    }
}
