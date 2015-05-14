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
using DwAPI.Models;

namespace DwAPI.Controllers
{
    public class CheckInOutsController : ApiController
    {
        private SmartReporting db = new SmartReporting();

        // GET: api/CheckInOuts
        public IQueryable<FactCheckInOut> GetFactCheckInOuts()
        {
            return db.FactCheckInOuts.Take(100);
        }

        // GET: api/CheckInOuts/5
        [ResponseType(typeof(FactCheckInOut))]
        public IHttpActionResult GetFactCheckInOut(long id)
        {
            FactCheckInOut factCheckInOut = db.FactCheckInOuts.Find(id);
            if (factCheckInOut == null)
            {
                return NotFound();
            }

            return Ok(factCheckInOut);
        }

        // PUT: api/CheckInOuts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFactCheckInOut(long id, FactCheckInOut factCheckInOut)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != factCheckInOut.CheckInOutKey)
            {
                return BadRequest();
            }

            db.Entry(factCheckInOut).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactCheckInOutExists(id))
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

        // POST: api/CheckInOuts
        [ResponseType(typeof(FactCheckInOut))]
        public IHttpActionResult PostFactCheckInOut(FactCheckInOut factCheckInOut)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FactCheckInOuts.Add(factCheckInOut);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = factCheckInOut.CheckInOutKey }, factCheckInOut);
        }

        // DELETE: api/CheckInOuts/5
        [ResponseType(typeof(FactCheckInOut))]
        public IHttpActionResult DeleteFactCheckInOut(long id)
        {
            FactCheckInOut factCheckInOut = db.FactCheckInOuts.Find(id);
            if (factCheckInOut == null)
            {
                return NotFound();
            }

            db.FactCheckInOuts.Remove(factCheckInOut);
            db.SaveChanges();

            return Ok(factCheckInOut);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FactCheckInOutExists(long id)
        {
            return db.FactCheckInOuts.Count(e => e.CheckInOutKey == id) > 0;
        }
    }
}