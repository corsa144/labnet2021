using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CorsaroCristian.NorthwindTP4.Logica;

namespace CorsaroCristian.MVCTP7.CRUD.Controllers
{
    public class OrdersWebApiController : ApiController
    {
        OrdersLogic ordersLogic = new OrdersLogic();
        public IEnumerable<Orders> Get()
        {
            var listado = ordersLogic.GetAll();
            return listado;
        }
    }
}
