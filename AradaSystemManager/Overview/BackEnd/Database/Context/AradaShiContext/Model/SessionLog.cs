using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class SessionLog
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? LogDate { get; set; }

        public virtual ClientInfo Client { get; set; }
    }
}
