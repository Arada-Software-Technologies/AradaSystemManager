using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameAdmissionFee
    {
        public long Id { get; set; }
        public string GameGenreId { get; set; }
        public decimal Fee { get; set; }

        public virtual GameGenre GameGenre { get; set; }
    }
}
