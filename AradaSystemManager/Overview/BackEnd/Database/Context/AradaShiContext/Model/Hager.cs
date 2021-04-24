using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class Hager
    {
        public Hager()
        {
            HagerOuts = new HashSet<HagerOut>();
        }

        public long Id { get; set; }
        public int? ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<HagerOut> HagerOuts { get; set; }
    }
}
