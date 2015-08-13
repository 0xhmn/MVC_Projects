using System.Web.Mvc;

namespace Ctrl_Test.Areas.Dashboard.Controllers
{
	[RouteArea("dashboard")]
    public class DashboardController : Controller
    {
        // GET: Dashboard/Dashboard
		[Route]
        public ActionResult Index()
        {
	        return Content("this is dashoard index view");
        }

		[Route("getdashboard")]
		public ActionResult GetDashboard()
		{
			return View();
		}

		[Route("test")]
	    public string Test()
	    {
		    return "test from dashboard";
	    }

    }
}