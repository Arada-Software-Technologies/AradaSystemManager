using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewUsersHager
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public int? Available { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
