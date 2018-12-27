using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BackendAuth.Models;

namespace BackendAuth.Controllers
{
    public class BreaksController : ApiController
    {
        private AuthContext db = new AuthContext();

        // GET: api/Breaks
        public IQueryable<Break> GetBreaks()
        {
            return db.Breaks;
        }

        // GET: api/Breaks
        [Route("api/Breaks/userid/{player}")]
        public IQueryable<Break> GetBreaksById(string player)
        {
            return db.Breaks.Where(u => u.Player == player);
        }

        // GET: api/Breaks/5
        [ResponseType(typeof(Break))]
        public IHttpActionResult GetBreak(int id)
        {
            Break @break = db.Breaks.Find(id);
            if (@break == null)
            {
                return NotFound();
            }

            return Ok(@break);
        }

        // PUT: api/Breaks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBreak(int id, Break @break)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @break.BreakId)
            {
                return BadRequest();
            }

            db.Entry(@break).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakExists(id))
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

        // POST: api/Breaks
        [ResponseType(typeof(Break))]
        public IHttpActionResult PostBreak(Break @break)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Breaks.Add(@break);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = @break.BreakId }, @break);
        }

        // DELETE: api/Breaks/5
        [ResponseType(typeof(Break))]
        public IHttpActionResult DeleteBreak(int id)
        {
            Break @break = db.Breaks.Find(id);
            if (@break == null)
            {
                return NotFound();
            }

            db.Breaks.Remove(@break);
            db.SaveChanges();

            return Ok(@break);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BreakExists(int id)
        {
            return db.Breaks.Count(e => e.BreakId == id) > 0;
        }
    }
}