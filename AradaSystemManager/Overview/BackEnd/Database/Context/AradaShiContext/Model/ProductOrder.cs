using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductOrder
    {
        public long Id { get; set; }
        public long? OrderId { get; set; }
        public long? ProductId { get; set; }
        public int? Qty { get; set; }
        public string Status { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual GebeyaOrder Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
