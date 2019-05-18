using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcMusicStore.App_Start;
using NLog;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly ILogger _logger;

        public MvcApplication()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        protected void Application_Start()
        {
            DependencyResolverConfig.RegisterDependencyResolver();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            PerformanceCountersConfig.Configure();

            _logger.Info("Application started.");
        }

        protected void Application_Error()
        {
            var lastError = Server.GetLastError();
            
            _logger.Error(lastError.ToString());
        }
    }
}
