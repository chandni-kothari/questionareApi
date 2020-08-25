using System;

namespace Questionnare.Models
{
    public class Question
    {
        public int questionId { get; set; }

        public int questionTypeId { get; set; }

        public string questionType { get; set; }

        public string questionDesc { get; set; }

        public string answerType { get; set; }

        private string answerTypeString;
        public string AnswerTypeString
        { 
            get {
                var arrayVal = answerType.Split(',');
                int value1 = Convert.ToInt32(arrayVal[0]);
                var types = ((AnswerTypeEnum)value1).ToString();
                if(arrayVal.Length > 1)
                {
                    int value2 = Convert.ToInt32(arrayVal[1]);
                    types += ((AnswerTypeEnum)value1).ToString();
                }
                return types; 
            }
            set { this.answerTypeString = value; }
        }
    }
}
