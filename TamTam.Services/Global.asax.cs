using System.Web.Http;

namespace TamTam.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Register api route
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Register dependencies that API will use
            DependencyConfig.RegisterDependencies();
        }
    }
}
