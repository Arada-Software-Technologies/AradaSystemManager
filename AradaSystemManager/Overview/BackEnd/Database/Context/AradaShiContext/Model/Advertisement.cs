using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Advertisement
    {
        public long Id { get; set; }
        public long? AdvertiserId { get; set; }
        public string Advertisement1 { get; set; }
        public string PhotoUrl { get; set; }
        public string AgeGroup { get; set; }
        public string AdType { get; set; }
        public string AdPage { get; set; }
        public int? Duration { get; set; }
        public string PopupOption { get; set; }
        public string Schedule { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual AdvertiserInfo Advertiser { get; set; }
    }
}
