using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Mvc;


namespace WebApiClient.Controllers
{
    public class HomeController : Controller
    {
        [BasicAuthenticationFilter]

        public ActionResult Index()
        {
            return View();
        }
    }
}