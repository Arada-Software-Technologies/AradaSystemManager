using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductSetting
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public bool? IsDirectOrderAvailable { get; set; }
        public string PaymentOption { get; set; }
        public double? UpFrontFeePercent { get; set; }
        public decimal? DeliveryFeePerKm { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ProductPaymentOption PaymentOptionNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
