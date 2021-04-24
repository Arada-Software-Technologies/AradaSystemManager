using System;
using System.Collections.Generic;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiContext.Model
{
    public partial class QuestionDifficultyMode
    {
        public QuestionDifficultyMode()
        {
            GameplayAlgorithms = new HashSet<GameplayAlgorithm>();
        }

        public string Mode { get; set; }
        public string Description { get; set; }
        public string SuggestedUsage { get; set; }

        public virtual ICollection<GameplayAlgorithm> GameplayAlgorithms { get; set; }
    }
}
