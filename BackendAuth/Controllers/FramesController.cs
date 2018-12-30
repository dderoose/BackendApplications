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
    public class FramesController : ApiController
    {
        private AuthContext db = new AuthContext();

        // GET: api/Frames
        public IQueryable<Frame> GetFrames()
        {
            return db.Frames;
        }


        // GET: api/Frames
        [Route("api/Frames/matchid/{matchid}")]
        public IQueryable<Frame> GetFramesByMatchId(int matchid)
        {
            //return db.Frames.Where(u => u.MatchId == matchid);
            return db.Frames.Where(u => u.MatchId == matchid).Include(t=>t.Breaks);
        }

        // GET: api/Frames/5
        [ResponseType(typeof(Frame))]
        public IHttpActionResult GetFrame(int id)
        {
            Frame frame = db.Frames.Find(id);
            if (frame == null)
            {
                return NotFound();
            }

            return Ok(frame);
        }

        // PUT: api/Frames/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFrame(int id, Frame frame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != frame.FrameId)
            {
                return BadRequest();
            }

            db.Entry(frame).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FrameExists(id))
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

        // POST: api/Frames
        [ResponseType(typeof(Frame))]
        public IHttpActionResult PostFrame(Frame frame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Frames.Add(frame);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = frame.FrameId }, frame);
        }

        // DELETE: api/Frames/5
        [ResponseType(typeof(Frame))]
        public IHttpActionResult DeleteFrame(int id)
        {
            Frame frame = db.Frames.Find(id);
            if (frame == null)
            {
                return NotFound();
            }

            db.Frames.Remove(frame);
            db.SaveChanges();

            return Ok(frame);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FrameExists(int id)
        {
            return db.Frames.Count(e => e.FrameId == id) > 0;
        }
    }
}