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
using ThongKeZone3.Models;

namespace ThongKeZone3.Controllers
{
    public class BK_ThonController : ApiController
    {
        private BKDS2019Entities db = new BKDS2019Entities();

        // GET: api/BK_Thon
        public IQueryable<BK_Thon> GetBK_Thon()
        {
            return db.BK_Thon;
        }

        // GET: api/BK_Thon/5
        [ResponseType(typeof(BK_Thon))]
        public IHttpActionResult GetBK_Thon(string id)
        {
            BK_Thon bK_Thon = db.BK_Thon.Find(id);
            if (bK_Thon == null)
            {
                return NotFound();
            }

            return Ok(bK_Thon);
        }

        // PUT: api/BK_Thon/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBK_Thon(string id, BK_Thon bK_Thon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bK_Thon.MaXa)
            {
                return BadRequest();
            }

            db.Entry(bK_Thon).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BK_ThonExists(id))
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

        // POST: api/BK_Thon
        [ResponseType(typeof(BK_Thon))]
        public IHttpActionResult PostBK_Thon(BK_Thon bK_Thon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BK_Thon.Add(bK_Thon);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BK_ThonExists(bK_Thon.MaXa))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = bK_Thon.MaXa }, bK_Thon);
        }

        // DELETE: api/BK_Thon/5
        [ResponseType(typeof(BK_Thon))]
        public IHttpActionResult DeleteBK_Thon(string id)
        {
            BK_Thon bK_Thon = db.BK_Thon.Find(id);
            if (bK_Thon == null)
            {
                return NotFound();
            }

            db.BK_Thon.Remove(bK_Thon);
            db.SaveChanges();

            return Ok(bK_Thon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BK_ThonExists(string id)
        {
            return db.BK_Thon.Count(e => e.MaXa == id) > 0;
        }
    }
}