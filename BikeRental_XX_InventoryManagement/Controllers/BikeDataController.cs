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
using BikeRental_XX_InventoryManagement.Models;
using System.Diagnostics;

namespace BikeRental_XX_InventoryManagement.Controllers
{
    public class BikeDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/BikeData/ListBikes
        [HttpGet]
        [Route("api/BikeData/LisTBikes")]
        public IEnumerable<BikeDto> ListBikes()
        {
            List<Bikes> Bikes = db.Bikes.ToList();
            List<BikeDto> BikeDtos = new List<BikeDto>();

            Bikes.ForEach(a => BikeDtos.Add(new BikeDto()
            {
                BikeID = a.BikeID,
                Brand = a.Brand,
                Model = a.Model,
                Type = a.Type,
                Available = a.Available
            }));
            return BikeDtos;
        }

        //testing the api
        [HttpGet]
        [Route("api/BikeData/Test")]
        public string Test()

        {
            return "Hello";
        }

        // GET: api/BikeData/FindBike/5
        [ResponseType(typeof(Bikes))]
        [HttpGet]
        public IHttpActionResult FindBike(int id)
        {
            Bikes Bikes = db.Bikes.Find(id);

            BikeDto BikeDto = new BikeDto()
            {
                BikeID = Bikes.BikeID,
                Brand = Bikes.Brand,
                Model = Bikes.Model,
                Type = Bikes.Type,
                Available = Bikes.Available
            };

            if (Bikes == null)
            {
                return NotFound();
            }

            return Ok(BikeDto);
        }

        // POST: api/BikeData/UpdateBike/5
        [ResponseType(typeof(void))]
        [HttpPost]
        public IHttpActionResult UpdateBike(int id, Bikes bikes)
        {



            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bikes.BikeID)
            {
                return BadRequest();
            }

            db.Entry(bikes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BikesExists(id))
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

        // POST: api/BikeData/AddBike
        [ResponseType(typeof(Bikes))]
        [HttpPost]
        public IHttpActionResult AddBike(Bikes bikes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bikes.Add(bikes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bikes.BikeID }, bikes);
        }

        // POST: api/BikeData/DeleteBike/5
        [ResponseType(typeof(Bikes))]
        [HttpPost]
        public IHttpActionResult DeleteBike(int id)
        {
            Bikes bikes = db.Bikes.Find(id);
            if (bikes == null)
            {
                return NotFound();
            }

            db.Bikes.Remove(bikes);
            db.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BikesExists(int id)
        {
            return db.Bikes.Count(e => e.BikeID == id) > 0;
        }
    }
}
