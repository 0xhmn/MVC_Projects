using System.Web.Mvc;

namespace Ctrl_Test.Areas.Blog.Controllers
{
	[RouteArea("Blog")]
    public class BlogController : BaseAppController
    {


    }

	// Main Class

	public class BaseAppController : Controller
	{

		[Route]
		public ActionResult Index()
		{
			return Content("this is blog index path");
		}
		[Route("recent")]
		public ActionResult ShowRecent()
		{
			return Content("recent posts");
		}

		[Route("Archive")]
		public ActionResult ShowArchive()
		{
			return View();
		}
		
	}
}