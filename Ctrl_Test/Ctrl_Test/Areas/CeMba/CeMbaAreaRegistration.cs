using System.Web.Mvc;

namespace Ctrl_Test.Areas.CeMba
{
    public class CeMbaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CeMba";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
			//context.MapRoute(
			//	"CeMba_default",
			//	"CeMba/{controller}/{action}/{id}",
			//	new { action = "Index", id = UrlParameter.Optional }
			//);
        }
    }
}