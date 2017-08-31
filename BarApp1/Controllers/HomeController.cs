using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            ViewBag.Message = "Number of Items on queue for Bartendar.";

            return View();
        }

        public ActionResult Queue() {

            ViewBag.Message = "Items on queue for Bartendar";

            return View();
            
            }
        }
    }