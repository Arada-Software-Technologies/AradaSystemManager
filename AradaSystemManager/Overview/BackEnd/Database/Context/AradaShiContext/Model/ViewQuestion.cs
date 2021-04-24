using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewQuestion
    {
        public string Id { get; set; }
        public string Genre { get; set; }
        public string DifficultyLevel { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string QuestionTypeId { get; set; }
        public string AttachmentUrl { get; set; }
    }
}
