using Dealership.Domain;
using Dealership.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dealership.Helpers;


namespace Dealership.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dealership()
        {

            List<IDealer> dealers = new List<IDealer>();
            DealershipDB db = new DealershipDB();

            dealers.AddRange(db.DealershipTable.Rows[0].ToObject<List<IDealer>>());
            return View();
        }

        public ActionResult AddNew()
        {
            return View("Dealership");
        }
    }
}