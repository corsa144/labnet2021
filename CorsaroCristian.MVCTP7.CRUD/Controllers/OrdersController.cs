using CorsaroCristian.MVCTP7.Models;
using CorsaroCristian.NorthwindTP4.Entidades;
using CorsaroCristian.NorthwindTP4.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsaroCristian.MVCTP7.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        OrdersLogic ordersLogic = new OrdersLogic();
        public ActionResult Index()
        {
            List<Orders> orders = ordersLogic.GetAll();
            List<OrdersView> ordersView = orders.Select(o => new OrdersView
            {
                Id = o.OrderID,
                Freight = (Decimal)o.Freight,
                OrderDate = (DateTime)o.OrderDate,
            }).ToList();
            return View(ordersView);
        }

        public ActionResult Insert()
        {
            return View("InsertOrder");
        }

        [HttpPost]
        public ActionResult Insert(OrdersView ordersView )
        {
            if (ordersView.Id != 0)
            {
                return Update(ordersView);
            }
            try
            {
                Orders orderEntity = new Orders
                {
                    Freight = ordersView.Freight,
                    OrderDate = ordersView.OrderDate,

                };
                ordersLogic.Add(orderEntity);

                return RedirectToAction("Index");
            }catch(CustomException ex)
            {
                return RedirectToAction("Index", "ErrorPersonalizado",new { mensaje = ex.Message });
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        } 

        public ActionResult Delete(int id)
        {
            try
            {
                ordersLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch(CustomException ex)
            {
                return RedirectToAction("Index", "ErrorPersonalizado", new {mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update(OrdersView ordersView)
        {
            try
            {
                Orders orderEntity = new Orders
                {
                    OrderID = ordersView.Id,
                    Freight = ordersView.Freight,
                    OrderDate = ordersView.OrderDate,

                };
                ordersLogic.Update(orderEntity);

                return RedirectToAction("Index");
            }catch (CustomException ex)
            {
                return RedirectToAction("Index", "ErrorPersonalizado", new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}