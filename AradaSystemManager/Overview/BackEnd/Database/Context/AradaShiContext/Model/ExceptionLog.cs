using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ExceptionLog
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public int? Hresult { get; set; }
        public string StackTrace { get; set; }
        public string InnerMessage { get; set; }
        public string InnerSource { get; set; }
        public int? InnerHresult { get; set; }
        public string InnerStackTrace { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
