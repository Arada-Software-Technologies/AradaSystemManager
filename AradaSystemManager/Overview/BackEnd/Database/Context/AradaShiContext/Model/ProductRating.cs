using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductRating
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long? ClientId { get; set; }
        public int? Rating { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual Product Product { get; set; }
    }
}
