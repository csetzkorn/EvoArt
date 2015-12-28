using System.Web.Mvc;
using System.Web.Routing;

namespace EvoArt.AspDotNetMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
        }
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterRoutes(RouteTable.Routes);
        }
    }
}
