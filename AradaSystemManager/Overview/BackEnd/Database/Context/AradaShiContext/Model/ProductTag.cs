using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductTag
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public string Tag { get; set; }

        public virtual Product Product { get; set; }
    }
}
