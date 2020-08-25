namespace Questionnare.Services.Services
{
    #region Namespaces

    using System;
    using Questionnare.Data.IRepository;
    using Questionnare.Models;
    using Questionnare.Services.IServices;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #endregion

    public class QuestionServices : IQuestionServices
    {
        #region Declarations

        public IRepository<Question> repository;

        #endregion

        #region Constructor

        public QuestionServices(IRepository<Question> _repository)
        {
            this.repository = _repository;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            try
            {
                return await repository.Query<Question>(Constants.selectAllQuestion);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Question> GetQuestion(int questionId)
        {
            try
            {
                var parameters = new { questionId = questionId };
                return await repository.QueryFirst<Question>(Constants.getOneQuestion, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> DeleteQuestion(int questionId)
        {
            try
            {
                var parameters = new { questionId = questionId };
                return await repository.QueryFirst<string>(Constants.deleteQuestion, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> AddQuestion(Question obj)
        {
            try
            {
                var parameters = new { 
                    questionId = obj.questionId,
                    questionTypeId = obj.questionTypeId,
                    questionDesc = obj.questionDesc,
                    answerType = obj.answerType
                };
                return await repository.QueryFirst<string>(Constants.addQuestion, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> UpdateQuestion(Question obj)
        {
            try
            {
                var parameters = new { 
                    questionId = obj.questionId,
                    answerType = obj.answerType,
                    questionDesc = obj.questionDesc
                };
                return await repository.QueryFirst<string>(Constants.updateQuestion, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AnswerCsvModel>> GetAllAnswers()
        {
            try
            {
                return await repository.Query<AnswerCsvModel>(Constants.selectAllAnswers);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        #endregion
    }
}
