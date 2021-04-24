using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ProductMedium
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public string FileType { get; set; }
        public string FileAddress { get; set; }

        public virtual AttachmentType FileTypeNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
