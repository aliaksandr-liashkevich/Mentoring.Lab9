using System.Web.Mvc;
using MvcMusicStore.Infrastructure;
using PerformanceCounterHelper;

namespace MvcMusicStore.App_Start
{
    public class PerformanceCountersConfig
    {
        public static void Configure()
        {
            var counterHelper = DependencyResolver.Current.GetService<CounterHelper<MvcMusicStoreCounters>>();

            counterHelper.RawValue(MvcMusicStoreCounters.GoToHome, 0);
            counterHelper.RawValue(MvcMusicStoreCounters.SuccessLogIn, 0);
            counterHelper.RawValue(MvcMusicStoreCounters.SuccessLogOff, 0);
            counterHelper.RawValue(MvcMusicStoreCounters.FailedLogIn, 0);
        }
    }
}