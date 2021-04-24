using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewLeaderboard
    {
        public long Id { get; set; }
        public int? Highscore { get; set; }
        public string PlayerName { get; set; }
    }
}
