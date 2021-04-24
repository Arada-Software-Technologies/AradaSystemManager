using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ClientAccount
    {
        public ClientAccount()
        {
            CardOuts = new HashSet<CardOut>();
            Deposits = new HashSet<Deposit>();
            HagerOuts = new HashSet<HagerOut>();
            Withdrawals = new HashSet<Withdrawal>();
        }

        public long Id { get; set; }
        public long? ClientId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual ICollection<CardOut> CardOuts { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<HagerOut> HagerOuts { get; set; }
        public virtual ICollection<Withdrawal> Withdrawals { get; set; }
    }
}
