namespace Questionnare.Models
{
    public static class Constants
    {
        public static readonly string selectAllCountries = "select country_id as countryId, country_name as countryName from [dbo].[Countries];";

        public static readonly string selectAllOccupations = "select occupation_id as occupationId, occupation_name as occupationName from [dbo].[Occupation];";

        public static readonly string selectAllQuestionType = "select type_id as typeId, type_name as typeName from [dbo].[QuestionType];";

        public static readonly string selectAllQuestion = "select question_id as questionId, quetype.type_name as questionType, question_desc as questionDesc, answer_type as answerType from [dbo].[Question] que join QuestionType quetype on quetype.type_id = que.question_type_id;";

        public static readonly string getOneQuestion = "select question_id as questionId, quetype.type_name as questionType, question_desc as questionDesc, answer_type as answerType from [dbo].[Question] que join QuestionType quetype on quetype.type_id = que.question_type_id where question_id = @questionId;";

        public static readonly string deleteQuestion = "delete from [dbo].[Question] where question_id = @questionId;";

        public static readonly string updateQuestion = "update [dbo].[Question] set question_desc = @questionDesc, answer_type = @answerType where question_id = @questionId;";

        public static readonly string addQuestion = "INSERT INTO[dbo].[Question] ([question_id], [question_type_id], [question_desc], [answer_type]) VALUES(@questionId, @questionTypeId, @questionDesc, @answerType)";

        public static readonly string selectAllAnswers = "select CONCAT(que.question_desc,',',answer_desc) as answerStr from [dbo].[Answers] ans join Question que on ans.question_id = que.question_id;";
    }
}
