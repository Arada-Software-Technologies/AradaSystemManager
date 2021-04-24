using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewProduct
    {
        public long Id { get; set; }
        public long? SellerId { get; set; }
        public string Seller { get; set; }
        public int SouqId { get; set; }
        public int ShelfId { get; set; }
        public string Name { get; set; }
        public string NameEt { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string SizeEt { get; set; }
        public int? Qty { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string DescriptionEt { get; set; }
        public bool? IsVatIncluded { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
