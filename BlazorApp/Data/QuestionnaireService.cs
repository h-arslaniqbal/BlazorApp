using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class QuestionnaireService
    {
        public Task<List<QuestionModel>> GetQuestionsList()
        {
            List<QuestionModel> questionList = new List<QuestionModel>();


            QuestionModel question1 = new QuestionModel();
            question1.Question = "This is a disclaimer. Do you accept?";
            question1.QuestionType = AppConstants.QuestionType.RadioButton;
            question1.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 }, 
                {"No", 0 }
            };
            question1.Id = 1;
            question1.IsActive = true;
            question1.IsValid = true;
            question1.DisplayOrder = 1;
            questionList.Add(question1);


            QuestionModel question2 = new QuestionModel();
            question2.PreQuestionIds = new List<int> { 1 };
            question2.Question = "How would you rate your overall health?";
            question2.QuestionType = AppConstants.QuestionType.RadioButton;
            question2.Options = new Dictionary<string, double>()
            {
                {"Poor", 1 },
                {"Fair", 0.66 },
                { "Good", 0.33 },
                {"Excellent", 0 }
            };
            question2.Id = 2;
            question2.IsValid = true;
            question2.DisplayOrder = 2;
            question2.IsActive = false;
            questionList.Add(question2);


            var question3 = new QuestionModel();
            question3.Question = "Do you experience chronic pain, meaning that the pain has lasted for over 3 months or continued beyond the expected time for healing?";
            question3.QuestionType = AppConstants.QuestionType.RadioButton;
            question3.Id = 3;
            question3.DisplayOrder = 3;
            question3.PreQuestionIds = new List<int> { 2 };
            question3.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 },
                {"No", 0 }
            };
            questionList.Add(question3);


            var question4 = new QuestionModel();
            question4.Question = "Do you have this pain on a daily basis?";
            question4.QuestionType = AppConstants.QuestionType.RadioButton;
            question4.Id = 4;
            question4.DisplayOrder = 4;
            question4.PreQuestionIds = new List<int> { 3 };
            question4.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 },
                {"No", 0 }
            };
            questionList.Add(question4);


            var question5 = new QuestionModel();
            question5.Question = "Does your pain interfere with your sleep?";
            question5.QuestionType = AppConstants.QuestionType.RadioButton;
            question5.Id = 5;
            question5.DisplayOrder = 5;
            question5.PreQuestionIds = new List<int> { 3 };
            question5.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 },
                {"No", 0 }
            };
            questionList.Add(question5);


            var question6 = new QuestionModel();
            question6.Question = "Does your pain impact your ability to do day-to-day activities? (Such as looking after yourself, your home or engaging in social activities)";
            question6.QuestionType = AppConstants.QuestionType.RadioButton;
            question6.Id = 6;
            question6.DisplayOrder = 6;
            question6.PreQuestionIds = new List<int> { 3 };
            question6.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 },
                {"No", 0 }
            };
            questionList.Add(question6);


            var question7 = new QuestionModel();
            question7.Question = "How often are you taking pain medications?";
            question7.QuestionType = AppConstants.QuestionType.RadioButton;
            question7.Id = 7;
            question7.DisplayOrder = 7;
            question7.PreQuestionIds = new List<int> { 3, 6 };
            question7.Options = new Dictionary<string, double>()
            {
                {"Not at All", 0 },
                {"1-2 times per week", 23 },
                {"3-5 times per week", 23 },
                {"everyday", 23 }
            };
            questionList.Add(question7);


            var question8 = new QuestionModel();
            question8.Question = "What equipment you have in your home to help you move around safely?";
            question8.QuestionType = AppConstants.QuestionType.Textbox;
            question8.IsValid = true;
            question8.Id = 8;
            question8.DisplayOrder = 8;
            questionList.Add(question8);
            

            var question9 = new QuestionModel();
            question9.Question = "Are you able to dress yourself?";
            question9.QuestionType = AppConstants.QuestionType.RadioButton;
            question9.IsValid = true;
            question9.Options = new Dictionary<string, double>()
            {
                {"Yes", 1 },
                {"No", 0 }
            };
            question9.Id = 9;
            question9.DisplayOrder = 9;
            questionList.Add(question9);


            var question10 = new QuestionModel();
            question10.Question = "Is there anything else you want your health care team to know about your health needs?";
            question10.QuestionType = AppConstants.QuestionType.Textbox;
            question10.IsValid = true;
            question10.Id = 10;
            question10.DisplayOrder = 10;
            questionList.Add(question10);

            questionList = questionList.OrderBy(x => x.DisplayOrder).ToList();

            return Task.FromResult(questionList);
        }


    }
}
