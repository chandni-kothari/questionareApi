namespace Questionnare.Api.App_Start
{
    #region Namespaces

    using Autofac;
    using Autofac.Integration.WebApi;
    using Questionnare.Services;
    using System.Reflection;
    using System.Web.Http;

    #endregion

    /// <summary>
    /// UnityConfig
    /// </summary>
    public class UnityConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterModule<ServiceModule>();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}