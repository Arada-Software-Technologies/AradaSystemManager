using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class BankSetting
    {
        public int Id { get; set; }
        public int? BankId { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
