using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ctrl_Test.Controllers
{
	[RoutePrefix("books")]
    public class TestController : Controller
    {
        // GET: Test
		// new route:
		// admin/menu/Index
		[Route]
		// books
        public ActionResult Index()
        {
            return View();
        }

		[Route("{isbn?}")]
		// books/13242
	    public string StringTest(string isbn)
	    {
			if (!String.IsNullOrEmpty(isbn))
			{
				return "ISBN number is " + isbn;
			}
		    return "this is book page without isbn";
	    }

		[Route("query")]
		// books/query?name=hanna
	    public ActionResult QueryStringTest()
	    {
		    string name = Request.QueryString["name"];
		    return Content(String.Format("your name is {0}", name));
	    }
    }
}