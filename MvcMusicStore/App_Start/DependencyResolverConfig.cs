using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MvcMusicStore.Controllers;
using MvcMusicStore.Infrastructure;
using NLog;
using PerformanceCounterHelper;

namespace MvcMusicStore.App_Start
{
    public class DependencyResolverConfig
    {
        public static void RegisterDependencyResolver()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(HomeController).Assembly);
            builder.Register(c => LogManager.GetLogger("TestLogger"))
                .As<ILogger>();

            builder.Register(c => PerformanceHelper.CreateCounterHelper<MvcMusicStoreCounters>("MvcMusicStore project"))
                .SingleInstance()
                .As<CounterHelper<MvcMusicStoreCounters>>();

            var container = builder.Build();
            var resolver = new AutofacDependencyResolver(container);

            DependencyResolver.SetResolver(resolver);
        }
    }
}