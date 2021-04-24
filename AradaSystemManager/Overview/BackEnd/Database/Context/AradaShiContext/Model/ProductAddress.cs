using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductAddress
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public string ShopName { get; set; }
        public string ShopNameEt { get; set; }
        public string City { get; set; }
        public string CityEt { get; set; }
        public string LocationDescription { get; set; }
        public string LocationDescriptionEt { get; set; }
        public string MapLocation { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public virtual Product Product { get; set; }
    }
}
