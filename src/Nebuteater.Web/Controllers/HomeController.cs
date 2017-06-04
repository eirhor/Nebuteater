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
        public ActionResult Index()
        {
            var model = new List<Play>();
            return View(model);
        }
    }
}