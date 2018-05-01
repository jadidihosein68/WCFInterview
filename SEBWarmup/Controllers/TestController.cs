using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEBWarmup.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult RouteTest(string pm1 , string pm2) {

            return Content(pm1 + pm2);

        }

        //http://localhost:1589/Test/01
        [Route("Test/{pm1:regex(\\d{2}):range(1,25)}")] // regex is not string thats why we have to put "\" twice
        public ActionResult attributerouting(string pm1)
        {

            return Content(pm1 );

        }



    }
}