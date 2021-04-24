using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductSize
    {
        public ProductSize()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string SizeCategory { get; set; }
        public string Description { get; set; }
        public string DescriptionEt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
