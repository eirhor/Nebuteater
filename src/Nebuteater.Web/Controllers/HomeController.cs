using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nebuteater.Models.Entities;
using Nebuteater.Models.Enums;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDefaultPlayService _playService;

        public HomeController(IDefaultPlayService playService)
        {
            if (playService == null) throw new ArgumentNullException(nameof(playService));
            _playService = playService;
        }

        public ActionResult Index()
        {
            var model = new List<Play>();
            return View(model);
        }
    }
}