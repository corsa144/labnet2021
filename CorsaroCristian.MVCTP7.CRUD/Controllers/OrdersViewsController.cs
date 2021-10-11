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

    public class OrdersViewsController : ApiController
    {


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
        public void Delete(int id)
        {

        }

    }
}
