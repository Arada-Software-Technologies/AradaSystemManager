using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class HagerOut
    {
        public long Id { get; set; }
        public long? HagerId { get; set; }
        public long? ClientAccountId { get; set; }
        public string Reference { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientAccount ClientAccount { get; set; }
        public virtual Hager Hager { get; set; }
    }
}
