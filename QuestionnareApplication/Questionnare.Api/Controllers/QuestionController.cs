using Questionnare.Models;
using Questionnare.Services.IServices;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace Questionnare.Api.Controllers
{
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        public IQuestionServices questionService;

        public QuestionController(IQuestionServices _questionService)
        {
            this.questionService = _questionService;
        }

        [Route("getAllQuestion")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAllQuestion()
        {
            try
            {
                var result = await questionService.GetAllQuestions();
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }

        }

        [Route("getQuestionById/{questionId}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetQuestionById(int questionId)
        {
            try
            {
                var result = await questionService.GetQuestion(questionId);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }

        }

        [Route("getAnswerCsv")]
        [HttpGet]
        public HttpResponseMessage GetAnswerCsv()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);

            var data = questionService.GetAllAnswers();
            data.Wait();
            foreach (var item in data.Result)
            {
                writer.WriteLine(item.answerStr);
            }
            writer.Flush();
            stream.Position = 0;

            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/csv");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "Answers.csv" };
            return result;
        }

        [Route("addQuestion")]
        [HttpPost]
        public async Task<IHttpActionResult> AddQuestion(Question obj)
        {
            try
            {
                var result = await questionService.AddQuestion(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }
        }

        [Route("updateQuestion")]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateQuestion(Question obj)
        {
            try
            {
                var result = await questionService.UpdateQuestion(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }
        }

        [Route("deleteQuestion/{questionId}")]
        [HttpGet]
        public async Task<IHttpActionResult> DeleteQuestion(int questionId)
        {
            try
            {
                var result = await questionService.DeleteQuestion(questionId);
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }

        }
    }
}
