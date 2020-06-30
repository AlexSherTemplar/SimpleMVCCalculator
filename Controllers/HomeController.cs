using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string fst, string sec, string operation)
        {
            int a = Convert.ToInt32(fst);
            int b = Convert.ToInt32(sec);
            int c = 0;
            switch (operation)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                default:
                    c = 0;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }

    }
}