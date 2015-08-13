using System.Web.Mvc;

namespace Ctrl_Test.Controllers
{

	public class HomeController : Controller
	{
		// /Test/Index
		public ActionResult Index()
		{
			return View();
		}

	}
}