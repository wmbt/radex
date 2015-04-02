using System;
using System.Collections.Generic;
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

        public ActionResult Index()
        {
            string path = HttpContext.Server.MapPath("~/Data/data.csv");
            var strings = System.IO.File.ReadAllLines(path, Encoding.GetEncoding(1251))
                .Select(x => x.Split(';').ToArray()).ToArray();
            ViewData["Cells"] = strings;
            
            return View();
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
