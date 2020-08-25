using System.Web.Http;

namespace Questionnare.Api.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            //Configure AutoFac  
            UnityConfig.Initialize(GlobalConfiguration.Configuration);
        }

    }
}