namespace Questionnare.Api.Controllers
{

    #region Namespaces

    using Questionnare.Services.IServices;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    #endregion

    [RoutePrefix("api/occupation")]
    public class OccupationController : ApiController
    {
        public IOccupationServices occupationService;

        public OccupationController(IOccupationServices _occupationService)
        {
            this.occupationService = _occupationService;
        }


        #region Occupation Methods

        [Route("getAllOccupations")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAllCountries()
        {
            try
            {
                var result = await occupationService.GetAllOccupations();
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
