using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ClientAddress
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string LastLocation { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ClientInfo Client { get; set; }
    }
}
