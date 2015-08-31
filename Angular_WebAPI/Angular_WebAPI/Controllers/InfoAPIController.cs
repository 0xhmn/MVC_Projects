using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Angular_WebAPI.Models;

namespace Angular_WebAPI.Controllers
{
    public class InfoAPIController : ApiController
    {
        private MyDbEntities _db = new MyDbEntities();

        // GET: api/InfoAPI
        public IQueryable<InfoTable> GetInfo()
        {
            return _db.InfoTables;
        }


        // GET: api/InfoAPI/id
        [ResponseType(typeof(InfoTable))]
        public IHttpActionResult GetInfo(int id)
        {
            var query = _db.InfoTables.Find(id);
            if (query == null)
            {
                return NotFound();
            }
            return Ok(query);
        }

        // Updating
        // PUT: api/InfoAPI/id
        public IHttpActionResult PutInfo(int id, InfoTable personalInformation)
        {
            if (id != personalInformation.Id)
            {
                return BadRequest();
            }
            // ?
            _db.Entry(personalInformation).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonInformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }


        // POST: api/InfoAPI/5
        [ResponseType(typeof(InfoTable))]
        public IHttpActionResult PostInfo(InfoTable personalInformation)
        {
            _db.InfoTables.Add(personalInformation);
            _db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = personalInformation.Id }, personalInformation);
        }


        // check if the id exists
        public bool PersonInformationExists(int id)
        {
            return _db.InfoTables.Count(p => p.Id == id) > 0;
        }
    }
}
