using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewMinimumPlayer
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public int? MinPlayer { get; set; }
    }
}
