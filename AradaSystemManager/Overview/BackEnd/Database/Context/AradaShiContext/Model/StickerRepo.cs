﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class StickerRepo
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string MessageType { get; set; }
        public string AttachmentId { get; set; }
        public string Message { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}