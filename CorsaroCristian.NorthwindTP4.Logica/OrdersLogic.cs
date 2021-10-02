using CorsaroCristian.NorthwindTP4.Datos;
using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class OrdersLogic :BaseLogic, IABMLogic<Orders>
    {

        public List<Orders> GetAll()
        {
            return contexto.Orders.ToList();
        }

        public void Add(Orders orders)
        {
            try
            {
                contexto.Orders.Add(orders);
                contexto.SaveChanges();
            } catch (NotSupportedException ex)
            {
                throw new CustomException(ex.Message);
            } catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }

        public void Delete(int id)
        {
            try
            {
                var orderAEliminar = contexto.Orders.First(o => o.OrderID == id);
                //var orderAEliminar = contexto.Orders.Find(id);
                contexto.Orders.Remove(orderAEliminar);
                contexto.SaveChanges();
            }catch(ArgumentOutOfRangeException ex)
            {
                throw new CustomException(ex.Message);
            }catch(Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }
        /// <summary>
        /// Los siguientes campos pueden modificarse: Freight, OrderDate, Customers y RequiredDate.
        /// </summary>
        /// <param name="order"></param>
        public void Update(Orders order)
        {
            try
            {
                var orderUpdate = contexto.Orders.Find(order.OrderID);
                orderUpdate.Freight = order.Freight;
                orderUpdate.OrderDate = order.OrderDate;
                orderUpdate.Customers = order.Customers;
                orderUpdate.RequiredDate = order.RequiredDate;
                orderUpdate.ShipAddress = order.ShipAddress;
                orderUpdate.ShipCity = order.ShipCity;
                orderUpdate.ShipCountry = order.ShipCountry;
                orderUpdate.ShipName = order.ShipName;
                orderUpdate.ShippedDate = order.ShippedDate;
                orderUpdate.ShipPostalCode = order.ShipPostalCode;
                orderUpdate.ShipRegion = order.ShipRegion;
                orderUpdate.ShipVia = order.ShipVia;

                contexto.SaveChanges();
            }catch(InvalidOperationException ex)
            {
                throw new CustomException(ex.Message);
            }catch(Exception ex)
            {
                throw new CustomException(ex.Message);
            }

        }
    }
}
