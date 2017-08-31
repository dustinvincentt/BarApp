using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarApp1.Models;

namespace BarApp1.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            var menuList = new List<drinks>{
                new drinks() { beverage = "Beer", cost = 5 } ,
                new drinks() { beverage = "Wine", cost = 6 } ,
                new drinks() { beverage = "Apple Martini", cost = 8 } ,
                        };

            return View(menuList);
        }
    }
}