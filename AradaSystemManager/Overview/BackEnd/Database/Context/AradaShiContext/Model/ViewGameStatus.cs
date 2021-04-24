using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGameStatus
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public DateTime GameSchedule { get; set; }
        public string Type { get; set; }
    }
}
