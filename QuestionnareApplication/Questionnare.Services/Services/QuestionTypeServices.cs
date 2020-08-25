namespace Questionnare.Services.Services
{

    #region Namespaces

    using Questionnare.Data.IRepository;
    using Questionnare.Models;
    using Questionnare.Services.IServices;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #endregion

    public class QuestionTypeServices : IQuestionTypeServices
    {
        #region Declarations

        public IRepository<QuestionType> repository;

        #endregion

        #region Constructor

        public QuestionTypeServices(IRepository<QuestionType> _repository)
        {
            this.repository = _repository;
        }

        #endregion

        #region QuestionTypeService

        public async Task<IEnumerable<QuestionType>> GetAllQuestionType()
        {
            try
            {
                return await repository.Query<QuestionType>(Constants.selectAllQuestionType);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
