using System.Diagnostics;
using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastructure
{
    [PerformanceCounterCategory("MvcMusicStore", PerformanceCounterCategoryType.SingleInstance, "MvcMusicStore")]
    public enum MvcMusicStoreCounters
    {
        [PerformanceCounter("GoToHomeCounter", "Number of attempts to go to home page.", PerformanceCounterType.NumberOfItems32)]
        GoToHome = 1,
    
        [PerformanceCounter("SuccessLogInCounter", "Number of success login attempts", PerformanceCounterType.NumberOfItems32)]
        SuccessLogIn = 2,
    
        [PerformanceCounter("SuccessLogOffCounter", "Number of success logoff attempts", PerformanceCounterType.NumberOfItems32)]
        SuccessLogOff = 3,

        [PerformanceCounter("FailedLogInCounter", "Number of failed login attempts", PerformanceCounterType.NumberOfItems32)]
        FailedLogIn = 4,
    }
}