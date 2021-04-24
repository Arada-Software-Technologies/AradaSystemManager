using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class GameSetting
    {
        public GameSetting()
        {
            SponsoredGameInfos = new HashSet<SponsoredGameInfo>();
        }

        public long Id { get; set; }
        public string GenreId { get; set; }
        public string DifficultyLevel { get; set; }
        public int? MaxPlayer { get; set; }
        public bool? IsSponsored { get; set; }

        public virtual GameGenre Genre { get; set; }
        public virtual ICollection<SponsoredGameInfo> SponsoredGameInfos { get; set; }
    }
}
