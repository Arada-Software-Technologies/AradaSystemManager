using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class AdvertiserInfo
    {
        public AdvertiserInfo()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public long Id { get; set; }
        public string Company { get; set; }
        public string Tin { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
