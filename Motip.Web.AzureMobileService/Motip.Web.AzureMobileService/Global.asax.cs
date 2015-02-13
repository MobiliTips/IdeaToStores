using System.Web.Http;
using System.Web.Routing;

namespace Motip.Web.AzureMobileService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}