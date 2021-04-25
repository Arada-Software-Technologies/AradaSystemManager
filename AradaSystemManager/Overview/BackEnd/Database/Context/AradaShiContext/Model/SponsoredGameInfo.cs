﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class SponsoredGameInfo
    {
        public long Id { get; set; }
        public long? SponsorId { get; set; }
        public long? GameSettingId { get; set; }
        public decimal? SponsoredAmount { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual GameSetting GameSetting { get; set; }
        public virtual GameSponserInfo Sponsor { get; set; }
    }
}