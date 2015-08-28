using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.Web.Mvc;
using GeekQuiz.Models;

namespace GeekQuiz.Controllers
{
    [System.Web.Mvc.Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }

}