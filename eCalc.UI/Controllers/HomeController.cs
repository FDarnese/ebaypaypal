using eCalc.Backend.ExchangeRates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCalc.UI.Controllers
{
    public class HomeController : Controller
    {
        private CurrenciesService currenciesService = new CurrenciesService(new NBPExchangeRatesClient());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}