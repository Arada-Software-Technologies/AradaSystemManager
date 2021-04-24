using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiManagerContext.Model
{
    public partial class SysUserInfo
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] Picture { get; set; }
        public int? Title { get; set; }
        public string AccStatus { get; set; }
        public int AccCreator { get; set; }
        public DateTime AccCreatedOn { get; set; }
        public int SubSys1Per { get; set; }
        public int SubSys2Per { get; set; }
        public int SubSys3Per { get; set; }
        public int SubSys4Per { get; set; }
        public int SubSys5Per { get; set; }
        public int SubSys6Per { get; set; }

        public virtual SysUserCridential AccCreatorNavigation { get; set; }
        public virtual SysUserCridential IdNavigation { get; set; }
        public virtual Title TitleNavigation { get; set; }
    }
}
