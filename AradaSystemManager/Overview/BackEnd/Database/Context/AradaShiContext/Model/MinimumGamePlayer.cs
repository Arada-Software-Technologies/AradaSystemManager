using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class MinimumGamePlayer
    {
        public long Id { get; set; }
        public string GameType { get; set; }
        public int? MinPlayer { get; set; }

        public virtual GameType GameTypeNavigation { get; set; }
    }
}
