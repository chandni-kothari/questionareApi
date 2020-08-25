namespace Questionnare.Api.Controllers
{

    #region Namespaces

    using Questionnare.Services.IServices;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    #endregion

    [RoutePrefix("api/countries")]
    public class CountriesController : ApiController
    {
        public ICountriesService countriesService;

        public CountriesController(ICountriesService _countriesService)
        {
            this.countriesService = _countriesService;
        }


        #region Countries Methods

        [Route("getAllCountries")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAllCountries()
        {
            try
            {
                var result = await countriesService.GetAllCountries();
                return Ok(result);
            }
            catch (System.Exception)
            {
                return InternalServerError(new Exception("Sorry something went wrong!"));
            }
            
        }

        #endregion
    }
}
