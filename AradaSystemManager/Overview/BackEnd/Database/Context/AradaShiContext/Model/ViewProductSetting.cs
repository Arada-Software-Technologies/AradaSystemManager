using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewProductSetting
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public bool? IsDirectOrderAvailable { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? UpFrontFeePercent { get; set; }
        public decimal? DeliveryFeePerKm { get; set; }
    }
}
