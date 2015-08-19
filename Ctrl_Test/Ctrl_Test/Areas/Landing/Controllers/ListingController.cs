using System.Threading.Tasks;
using System.Web.Mvc;

// it'll redirect everything to a single platform
using Ctrl_Test.Models;

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

        /// <summary>
        /// this part is for sync and async testing
        /// and works with Gizmo model
        /// </summary>
        
        // 1- sync method
	    [Route("Gizmosync")]
	    public ActionResult Gizmo()
	    {
            // passing a list of gizmos
            ViewBag.SyncOrAsync = "Sync";
	        var gizmos = new GizmoService();
	        return View("Gizmo", gizmos.GetGizmos());
	    }

        // 2- async method
        /**The return type of Task<ActionResult>  represents ongoing work and provides 
         * callers of the method with a handle through which to wait for the 
         * asynchronous operation’s completion. In this case, 
         * the caller is the web service. Task<ActionResult>  
         * represents ongoing work with a result of ActionResult.
         */
	    [Route("GizmoAsync")]
	    public async Task<ActionResult> GizmoAsync()
	    {
	        ViewBag.SyncOrAsync = "Async";
	        var gizmos = new GizmoService();
            return View("Gizmo", await gizmos.GetGizmosAsync());    
            // Because you  don’t want to do anything else until you have the gizmo 
            // data, the code awaits the task (using the await keyword)
	    }
    }
}