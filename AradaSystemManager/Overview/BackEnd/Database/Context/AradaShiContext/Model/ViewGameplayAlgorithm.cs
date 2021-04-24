using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class ViewGameplayAlgorithm
    {
        public long Id { get; set; }
        public decimal? EasyQuestionPercent { get; set; }
        public decimal? VeryEasyQuestionPercent { get; set; }
        public decimal? HardQuestionPercent { get; set; }
        public decimal? VeryHardQuestionPercent { get; set; }
        public string DifficultyMode { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
