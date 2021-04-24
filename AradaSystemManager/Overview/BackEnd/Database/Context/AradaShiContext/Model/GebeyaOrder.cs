using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GebeyaOrder
    {
        public GebeyaOrder()
        {
            OrderShippingAddresses = new HashSet<OrderShippingAddress>();
            ProductOrders = new HashSet<ProductOrder>();
        }

        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string Status { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual ICollection<OrderShippingAddress> OrderShippingAddresses { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
