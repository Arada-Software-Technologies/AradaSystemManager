using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Product
    {
        public Product()
        {
            ProductAddresses = new HashSet<ProductAddress>();
            ProductMedia = new HashSet<ProductMedium>();
            ProductOrders = new HashSet<ProductOrder>();
            ProductRatings = new HashSet<ProductRating>();
            ProductSettings = new HashSet<ProductSetting>();
            ProductTags = new HashSet<ProductTag>();
        }

        public long Id { get; set; }
        public long? SellerId { get; set; }
        public int ShelfId { get; set; }
        public string Name { get; set; }
        public string NameEt { get; set; }
        public decimal Price { get; set; }
        public int? Size { get; set; }
        public int? Qty { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string DescriptionEt { get; set; }
        public bool? IsVatIncluded { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ProductSeller Seller { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual ProductSize SizeNavigation { get; set; }
        public virtual ICollection<ProductAddress> ProductAddresses { get; set; }
        public virtual ICollection<ProductMedium> ProductMedia { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
        public virtual ICollection<ProductSetting> ProductSettings { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
