using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

using System.Web.Mvc;
using CorsaroCristian.MVCTP7.Models;
//using CorsaroCristian.NorthwindTP4.Datos;

namespace CorsaroCristian.MVCTP7.CRUD.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using CorsaroCristian.MVCTP7.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<OrdersView>("OrdersViews");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class OrdersViewsController : ApiController
    {
        //private NorthwindContext db = new NorthwindContext();

        public IEnumerable<string> Get()
        {
            return new string[] { "Value1, value2"};
        }


        public string Get( int id)
        {
            return "Value";
        }

        // PUT: api/OrdersViews(5)
        public void Put(int id, [FromBody] string value)
        {

        }

        // POST: odata/OrdersViews
        public void Post([FromBody] string value)
        {

        }

        // PATCH: odata/OrdersViews(5)
        /*[AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<OrdersView> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OrdersView ordersView = db.OrdersViews.Find(key);
            if (ordersView == null)
            {
                return NotFound();
            }

            patch.Patch(ordersView);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersViewExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ordersView);
        }*/

        // DELETE: odata/OrdersViews(5)
        public void Delete(int id)
        {

        }
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrdersViewExists(int key)
        {
            return db.OrdersViews.Count(e => e.Id == key) > 0;
        }
        */
    }
}
