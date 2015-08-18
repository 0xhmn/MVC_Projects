using System.Web.Mvc;

// it'll redirect everything to a single platform
namespace Ctrl_Test.Areas.Landing.Controllers
{
	[RouteArea("Landing")]
    public class ListingController : Controller
    {
        
		[Route("~/"), Route("")]
        public ActionResult Index()
        {
            return View("~/Areas/Landing/Views/Listing/Index.cshtml");
        }
    }
}