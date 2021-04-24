using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Souq
    {
        public Souq()
        {
            Shelves = new HashSet<Shelf>();
            SouqServiceFeeLogs = new HashSet<SouqServiceFeeLog>();
            SouqSettings = new HashSet<SouqSetting>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionEt { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Shelf> Shelves { get; set; }
        public virtual ICollection<SouqServiceFeeLog> SouqServiceFeeLogs { get; set; }
        public virtual ICollection<SouqSetting> SouqSettings { get; set; }
    }
}
