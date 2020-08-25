namespace Questionnare.Models
{
    public class Answer
    {
        public int answerId { get; set; }

        public string answerDesc { get; set; }

        public int questionId { get; set; }

        public string questionString { get; set; }

        public string answerType { get; set; }

        public string answerTypeString { get; set; }

        public string answerStr { get; set; }
        
    }

    public class AnswerCsvModel
    {
        public string answerStr { get; set; }

    }
}
