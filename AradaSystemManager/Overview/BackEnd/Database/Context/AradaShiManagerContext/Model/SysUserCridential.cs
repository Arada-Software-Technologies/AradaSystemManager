using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiManagerContext.Model
{
    public partial class SysUserCridential
    {
        public SysUserCridential()
        {
            SysLogs = new HashSet<SysLog>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<SysLog> SysLogs { get; set; }
    }
}
