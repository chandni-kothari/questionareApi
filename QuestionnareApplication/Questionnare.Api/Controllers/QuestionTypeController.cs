namespace Questionnare.Api.Controllers
{

    #region Namespaces

    using Questionnare.Services.IServices;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    #endregion

    [RoutePrefix("api/questionType")]
    public class QuestionTypeController : ApiController
    {
        public IQuestionTypeServices questionTypeService;

        public QuestionTypeController(IQuestionTypeServices _questionTypeService)
        {
            this.questionTypeService = _questionTypeService;
        }


        #region Occupation Methods

        [Route("getAllQuestionType")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAllCountries()
        {
            try
            {
                var result = await questionTypeService.GetAllQuestionType();
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }
            
        }

        #endregion
    }
}
