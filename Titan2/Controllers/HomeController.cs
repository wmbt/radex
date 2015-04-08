using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Titan2.Models;

namespace Titan2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string colName = "id", string order = "asc")
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Price(string colName = "id", string order = "asc") 
        {
            var cs = ConfigurationManager.ConnectionStrings["DefaultDb"];
            var repo = new Repository(cs.ConnectionString);

            return View(new PriceTable
            {
                Items = repo.GetItems("TITAN2_PRICE", x => new TableItem(x), colName + " " + order).ToArray(),
                SortColumn = colName,
                SortOrder = order
            });
        }
    }
}
