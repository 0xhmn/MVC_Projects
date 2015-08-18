using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ctrl_Test.Controllers
{
	[RouteArea]
    public abstract class BaseProgramPagesController : Controller
    {
		/**
		 * for some reason this action is called
		 * on root (~/)
		 */
        [Route]
        public ActionResult Index()
        {
	        // return Content("sfsaf");
	        // return View("~/Views/Pages/Index.cshtml");
            return View();
        }

		[Route("about")]
		public ActionResult About()
		{
			return View();
		}
    }
}