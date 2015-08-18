using System.Web.Mvc;
using Ctrl_Test.Areas.CeMba.Models;
using Ctrl_Test.Controllers;
using Ctrl_Test.Models.ViewModels;

namespace Ctrl_Test.Areas.CeMba.Controllers
{
	[RouteArea("CeMba")]
    // redirecting the controller and passing the CeMba model
	public class PagesController : BaseProgramPagesController<CeMbaEducationViewModel>
	{
	}
}