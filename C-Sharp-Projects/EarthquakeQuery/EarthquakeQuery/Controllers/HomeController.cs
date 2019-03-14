using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EarthquakeQuery.ViewModels;

namespace EarthquakeQuery.Controllers
{
    public class HomeController : Controller
    {
        CountryVm countryVm = new CountryVm();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search()
        {
            return View();
        }
    }
}