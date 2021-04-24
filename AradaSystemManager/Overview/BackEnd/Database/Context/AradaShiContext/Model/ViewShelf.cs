using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewShelf
    {
        public int Id { get; set; }
        public int? SouqId { get; set; }
        public string Souq { get; set; }
        public string Status { get; set; }
    }
}
