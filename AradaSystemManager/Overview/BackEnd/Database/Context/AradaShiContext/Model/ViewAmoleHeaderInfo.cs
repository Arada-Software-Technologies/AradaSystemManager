using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewAmoleHeaderInfo
    {
        public long Id { get; set; }
        public string Signature { get; set; }
        public string Ip { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }
    }
}
