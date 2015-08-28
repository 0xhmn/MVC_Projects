using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeekQuiz.Controllers
{
    public class TestController : ApiController
    {
        // get method of api
        // GET api/test
        [Route("test")]
        public List<string> Get()
        {
            var list = new List<string>
            {
                "one",
                "two",
                "three"
            };
            return list;
        } 
    }
}
