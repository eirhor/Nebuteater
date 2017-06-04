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

        [HttpGet]
        public ActionResult Index()
        {
            var model = _playService.GetAll();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Order(int performanceId)
        {
            return View("Order", new List<object>());
        }
    }
}