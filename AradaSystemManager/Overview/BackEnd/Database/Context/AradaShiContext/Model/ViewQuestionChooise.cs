using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewQuestionChooise
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Answer { get; set; }
        public bool? IsAnswer { get; set; }
    }
}
