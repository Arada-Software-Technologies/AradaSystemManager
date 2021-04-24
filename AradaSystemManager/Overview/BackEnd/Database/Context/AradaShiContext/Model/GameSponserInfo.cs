using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameSponserInfo
    {
        public GameSponserInfo()
        {
            SponsoredGameInfos = new HashSet<SponsoredGameInfo>();
        }

        public long Id { get; set; }
        public long? ClientId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Tin { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ClientInfo Client { get; set; }
        public virtual ICollection<SponsoredGameInfo> SponsoredGameInfos { get; set; }
    }
}
