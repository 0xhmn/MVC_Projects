using System.Web.Mvc;
using Angular_WebAPI.Models;

namespace Angular_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public string Test()
        {
            var testdb =  new MyDbEntities();
            var newentery = new InfoTable
            {
                Age = 44,
                FirstName = "Sara",
                Gender = "Female",
                Id = 10,
                LastName = "Dahi"
            };

            testdb.InfoTables.Add(newentery);
            testdb.SaveChanges();

            return "saved";
        }

    }

}