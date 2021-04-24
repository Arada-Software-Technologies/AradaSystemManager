using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewCard
    {
        public long Id { get; set; }
        public string VoucherPin { get; set; }
        public string SerialNumber { get; set; }
        public string SupplierName { get; set; }
        public int? CardAmount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Telecom { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
