using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewSouqSetting
    {
        public int Id { get; set; }
        public long? SellerId { get; set; }
        public int? ProductPostingQuota { get; set; }
        public int? ChildCategoryQuota { get; set; }
        public bool? EnableServiceFee { get; set; }
        public decimal? ServiceFee { get; set; }
        public int? MaxItemPerOrder { get; set; }
        public int? SouqId { get; set; }
    }
}
