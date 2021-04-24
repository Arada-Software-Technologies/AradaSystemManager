using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewServiceChargeRate
    {
        public long Id { get; set; }
        public string Reason { get; set; }
        public double? Rate { get; set; }
    }
}
