using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiManagerContext.Model
{
    public partial class SysLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ModifiedSystem { get; set; }
        public string ModificationType { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SysUserCridential User { get; set; }
    }
}
