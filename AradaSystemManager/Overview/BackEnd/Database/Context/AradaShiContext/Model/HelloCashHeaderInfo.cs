using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class HelloCashHeaderInfo
    {
        public int Id { get; set; }
        public string Signature { get; set; }
        public string LongTermToken { get; set; }
        public string Description { get; set; }
    }
}
