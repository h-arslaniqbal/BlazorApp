using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorApp.Data.AppConstants;

namespace BlazorApp.Data
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public int Id { get; set; }
        public int DisplayOrder { get; set; }
        public QuestionType QuestionType { get; set; }
        public IDictionary<string, double> Options { get; set; }
        public bool IsValid { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsActive { get; set; }
        
        public string Domain { get; set; }
        public string AnswerText { get; set; }
        public double AnswerScore { get; set; }
        public bool PreReqDone { get; set; }
        public List<int> PreQuestionIds { get; set; }
        public List<int> PostQuestionIds { get; set; }
        public double Score { get; set; }

        public QuestionModel()
        {
            Options = new Dictionary<string, double>();
            PreQuestionIds = new List<int>();
            PostQuestionIds = new List<int>();
            Score = 0;
        }

    }
}
