namespace Questionnare.Api
{
    #region Namespaces

    using System.Net.Http.Headers;
    using System.Web.Http;

    #endregion

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes
               .Add(new MediaTypeHeaderValue("text/html"));

            //var container = UnityConfig.Container;//I have registered controllers here!!!
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
