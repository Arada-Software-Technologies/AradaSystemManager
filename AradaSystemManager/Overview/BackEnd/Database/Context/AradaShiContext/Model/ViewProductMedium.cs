using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewProductMedium
    {
        public long? ProductId { get; set; }
        public string FileType { get; set; }
        public string FileAddress { get; set; }
    }
}
