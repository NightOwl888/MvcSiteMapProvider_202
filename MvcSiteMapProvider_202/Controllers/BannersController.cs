using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_202.Controllers
{
    public class BannersController : Controller
    {
        //
        // GET: /Banners/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Banners/Novo

        public ActionResult Novo()
        {
            return View();
        }

       
    }
}
