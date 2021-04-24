using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class CardOut
    {
        public long Id { get; set; }
        public long? ClientAccountId { get; set; }
        public long? CardId { get; set; }
        public string Reference { get; set; }
        public DateTime? CardoutDate { get; set; }

        public virtual Card Card { get; set; }
        public virtual ClientAccount ClientAccount { get; set; }
    }
}
