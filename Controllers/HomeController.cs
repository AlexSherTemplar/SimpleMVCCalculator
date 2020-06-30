using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCalculator.Controllers
{
    public class HomeController : Controller
    {
        public static List<HistoryItem> history = new List<HistoryItem>();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.history = history;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string fst, string sec, string operation)
        {
            double a, b;
            a = b = 0;
            if (!String.IsNullOrEmpty(fst) && !String.IsNullOrEmpty(sec))
            {
                a = Convert.ToDouble(fst);
                b = Convert.ToDouble(sec);
            }
            double c = 0;
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

            }
            ViewBag.Result = c;
            history.Add(new HistoryItem { a=a.ToString(), b=b.ToString(), oper = operation,res = c.ToString() });
            ViewBag.history = history;
            return View();
        }
        public class HistoryItem
        {
            public string a { get; set; }
            public string b { get; set; }
            public string oper { get; set; }
            public string res { get; set; }
        }

    }
}