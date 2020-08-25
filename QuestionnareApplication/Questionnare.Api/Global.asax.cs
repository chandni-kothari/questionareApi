namespace Questionnare.Api
{

    #region Namepaces

    using Questionnare.Api.App_Start;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;

    #endregion

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            Bootstrapper.Run();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
