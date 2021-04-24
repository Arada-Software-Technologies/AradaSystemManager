using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGame
    {
        public long Id { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public long Creator { get; set; }
        public DateTime GameSchedule { get; set; }
        public string GameScheduleEt { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal GameFee { get; set; }
        public int? TotalQuestions { get; set; }
        public bool? IsNumberOfQuestionCustom { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
