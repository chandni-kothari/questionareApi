using Questionnare.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Questionnare.Services.IServices
{
    public interface IQuestionServices
    {
        Task<IEnumerable<Question>> GetAllQuestions();
        Task<Question> GetQuestion(int questionId);

        Task<string> DeleteQuestion(int questionId);

        Task<string> AddQuestion(Question obj);

        Task<string> UpdateQuestion(Question obj);

        Task<IEnumerable<AnswerCsvModel>> GetAllAnswers();
    }
}
