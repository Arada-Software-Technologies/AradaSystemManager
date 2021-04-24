using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewProductRating
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long? ClientId { get; set; }
        public int? Rating { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int SouqId { get; set; }
    }
}
