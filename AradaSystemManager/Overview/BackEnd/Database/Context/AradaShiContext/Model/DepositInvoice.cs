﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class DepositInvoice
    {
        public long Id { get; set; }
        public long? DepositId { get; set; }
        public string InvoiceNumber { get; set; }
        public string Status { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Deposit Deposit { get; set; }
    }
}
