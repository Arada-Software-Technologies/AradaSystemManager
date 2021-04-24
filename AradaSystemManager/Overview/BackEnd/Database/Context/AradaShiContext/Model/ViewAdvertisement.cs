using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewAdvertisement
    {
        public long Id { get; set; }
        public string Company { get; set; }
        public string Advertisement { get; set; }
        public string PhotoUrl { get; set; }
        public string AdvertType { get; set; }
        public string Sitemap { get; set; }
        public int? Duration { get; set; }
        public string PopupOption { get; set; }
        public string Schedule { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public string AgeGroup { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
