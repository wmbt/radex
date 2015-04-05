using DataAccess;
using DemoSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
                
        public ActionResult Index(string colName = "id", string order = "asc")
        {
            var cs = ConfigurationManager.ConnectionStrings["DefaultDb"];
            var repo = new Repository(cs.ConnectionString);
            
            return View(new PriceTable {
                Items = repo.GetItems("RADEXMETAL_PRICE", x => new TableItem(x), colName + " " + order).ToArray(),
                SortColumn = colName,
                SortOrder = order
            });
        }
        public ActionResult Titan() 
        {
            return View();
        }

        public ActionResult About() 
        {
            return View();
        }
    }
}
