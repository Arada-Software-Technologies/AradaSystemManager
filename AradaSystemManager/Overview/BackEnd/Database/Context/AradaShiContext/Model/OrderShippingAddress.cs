using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class OrderShippingAddress
    {
        public long Id { get; set; }
        public long? OrderId { get; set; }
        public string ShippingAddress { get; set; }
        public string Description { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual GebeyaOrder Order { get; set; }
    }
}
