using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Shelf
    {
        public Shelf()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? SouqId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual Souq Souq { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
