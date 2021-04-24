using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewAnimatedSticker
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
    }
}
