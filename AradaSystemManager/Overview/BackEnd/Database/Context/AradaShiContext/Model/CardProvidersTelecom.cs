using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class CardProvidersTelecom
    {
        public CardProvidersTelecom()
        {
            Cards = new HashSet<Card>();
        }

        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
