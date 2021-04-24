using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductSeller
    {
        public ProductSeller()
        {
            Products = new HashSet<Product>();
            SouqSettings = new HashSet<SouqSetting>();
        }

        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string Status { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SouqSetting> SouqSettings { get; set; }
    }
}
