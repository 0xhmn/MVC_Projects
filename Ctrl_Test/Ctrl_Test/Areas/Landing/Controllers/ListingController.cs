using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

// it'll redirect everything to a single platform
using Ctrl_Test.Models;
using Ctrl_Test.Models.ViewModels;

namespace Ctrl_Test.Areas.Landing.Controllers
{
    [RouteArea("Landing")]
    public class ListingController : Controller
    {
        
        [Route("~/"), Route("")]
        public async Task<ActionResult> Index()
        {
            var programs = await GetActivePrograms();
            return View("~/Areas/Landing/Views/Listing/Index.cshtml", programs);
        }


        /**
         * getting active programs from db asyncly
         */
        public async Task<List<ProgramSelectViewModel>> GetActivePrograms()
        {
            // making a new task
            return await Task.Factory.StartNew(() => MakingActivePrograms());
        }

        public List<ProgramSelectViewModel> MakingActivePrograms()
        {
            Thread.Sleep(1000);
            // making objects instead of getting them from db
            // let's say we have two different programs:
            // 1- cemba
            // 2- ftmba
            var programs = new List<ProgramSelectViewModel>
            {
                new ProgramSelectViewModel
                {
                    Id = 1,
                    Name = "CeMBA",
                    Description = "Executive MBA",
                    OpenTerms = new List<string>{"Summer 2032", "Fall 2032"}
                },
                new ProgramSelectViewModel
                {
                    Id = 2,
                    Name = "FtMBA",
                    Description = "Full-Time MBA",
                    OpenTerms = new List<string>{"Summer 2032", "Fall 2032"}
                },
                new ProgramSelectViewModel
                {
                    Id = 3,
                    Name = "PtMBA",
                    Description = "Part-Time MBA",
                    OpenTerms = new List<string>() // doesnt have any open term
                }

            };

            return programs;
        } 
    }


}