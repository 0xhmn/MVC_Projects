using System.Web.Mvc;
using Ctrl_Test.Models.ViewModels.Interfaces;

namespace Ctrl_Test.Controllers
{
    [RouteArea]
    public abstract class BaseProgramPagesController<TEducationViewModel> : Controller
        where TEducationViewModel : IEverythingShouldHave<TEducationViewModel>
    {
        /**
         * to make 'RouteArea' works, we need to make this class as 'abstract'
         */
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("term/{termSlug}")]
        // cemba/term/summer-2014
        public ActionResult Start(string termSlug)
        {
            return Content(termSlug);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("term/{termSlug}/education")]
        public ActionResult EducationUpdate(string termSlug)
        {
            return Content("not implemented yet");
        }
    }
}