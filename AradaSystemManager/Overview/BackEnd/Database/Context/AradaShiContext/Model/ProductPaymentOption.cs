using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductPaymentOption
    {
        public ProductPaymentOption()
        {
            ProductSettings = new HashSet<ProductSetting>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductSetting> ProductSettings { get; set; }
    }
}
