using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewPlayerScore
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public int? Score { get; set; }
        public int? Highscore { get; set; }
        public string Rank { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
