using CorsaroCristian.NorthwindTP4.Datos;
using CorsaroCristian.NorthwindTP4.Entidades;
using CorsaroCristian.NorthwindTP4.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CorsaroCristian.TP8.WebApi.Controllers
{
    public class OrdersController : ApiController
    {
        /// <summary>
        /// Permite consultar la informacion de mis ordenes
        /// </summary>
        OrdersLogic ordersLogic = new OrdersLogic();
        protected readonly NorthwindContext contexto = new NorthwindContext();
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            var listado = ordersLogic.GetAll();
            return listado;
        }
        [HttpGet]
        public Orders Get(int id)
        {
            try
            {
                var order = contexto.Orders.FirstOrDefault(o => o.OrderID == id);
                return order;
            }catch(Exception ex)
            {
                return null;
            }

        }

        [HttpPut]
        public Orders Put(Orders order)
        {
            try
            {
                ordersLogic.Update(order);
                return order;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpPost]
        public Orders Post(Orders order)
        {
            try
            {
                ordersLogic.Add(order);
                return order;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpDelete]
        public int Delete(int id)
        {
            try
            {
                ordersLogic.Delete(id);
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
