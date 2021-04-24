using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class AttachmentType
    {
        public AttachmentType()
        {
            ProductMedia = new HashSet<ProductMedium>();
        }

        public string Name { get; set; }

        public virtual ICollection<ProductMedium> ProductMedia { get; set; }
    }
}
