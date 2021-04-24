using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGameSetting
    {
        public long Id { get; set; }
        public string Genre { get; set; }
        public string DifficultyLevel { get; set; }
        public int? MaxPlayer { get; set; }
        public string GenreId { get; set; }
        public bool? IsSponsored { get; set; }
    }
}
