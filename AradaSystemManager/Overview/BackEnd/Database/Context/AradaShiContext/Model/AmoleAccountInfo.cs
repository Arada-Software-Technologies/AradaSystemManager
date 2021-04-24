using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class AmoleAccountInfo
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public string Residency { get; set; }
        public string AccountStatus { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
    }
}
