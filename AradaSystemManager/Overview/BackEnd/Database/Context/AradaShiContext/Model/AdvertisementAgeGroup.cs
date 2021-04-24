using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class AdvertisementAgeGroup
    {
        public AdvertisementAgeGroup()
        {
            ClientInfos = new HashSet<ClientInfo>();
        }

        public string AgeGroup { get; set; }
        public string Status { get; set; }

        public virtual ICollection<ClientInfo> ClientInfos { get; set; }
    }
}
