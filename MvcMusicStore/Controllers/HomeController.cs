﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MvcMusicStore.Infrastructure;
using MvcMusicStore.Models;
using NLog;
using PerformanceCounterHelper;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MusicStoreEntities _storeContext = new MusicStoreEntities();

        private readonly ILogger _logger;
        private readonly CounterHelper<MvcMusicStoreCounters> _musicStoreCounterHelper;

        public HomeController(ILogger logger, CounterHelper<MvcMusicStoreCounters> musicStoreCounterHelper)
        {
            _logger = logger;
            _musicStoreCounterHelper = musicStoreCounterHelper;
            ;
            _logger.Info($"Call {nameof(HomeController)} constructor.");
            _logger.Debug($"GoToHomeCounter = {musicStoreCounterHelper.GetInstance(MvcMusicStoreCounters.GoToHome)?.RawValue}.");
        }

        // GET: /Home/
        public async Task<ActionResult> Index()
        {
            _logger.Info("Enter to home page.");

            _musicStoreCounterHelper.Increment(MvcMusicStoreCounters.GoToHome);

            return View(await _storeContext.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(6)
                .ToListAsync());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _storeContext?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}