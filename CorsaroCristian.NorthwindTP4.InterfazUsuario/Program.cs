using CorsaroCristian.NorthwindTP4.Entidades;
using CorsaroCristian.NorthwindTP4.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    class Program
    {
        static void Main(string[] args)
        {

            string mensajeIngresado;
            int opcion;
            string datoIngresado;
            int numeroId;
            OrdersLogic ordersLogics = new OrdersLogic();
            CustomersLogic customersLogics = new CustomersLogic();
            ShippersLogic shippersLogics = new ShippersLogic();
            Console.Title = "Northwind app por Cristian Corsaro";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.Clear();
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("* 1-Alta Customers:                                          *");
                Console.WriteLine("* 2-Alta Orders:                                             *");
                Console.WriteLine("* 3-Alta Shippers:                                           *");
                Console.WriteLine("* 4-Baja Customers:                                          *");
                Console.WriteLine("* 5-Baja Orders:                                             *");
                Console.WriteLine("* 6-Baja Shippers:                                           *");
                Console.WriteLine("* 7-Modificar Customers:                                     *");
                Console.WriteLine("* 8-Modificar Orders:                                        *");
                Console.WriteLine("* 9-Modificar Shippers:                                      *");
                Console.WriteLine("* 10-Mostrar Customers:                                      *");
                Console.WriteLine("* 11-Mostrar Orders:                                         *");
                Console.WriteLine("* 12-Mostrar Shippers:                                       *");
                Console.WriteLine("* 13-Salir:                                                  *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("**************************************************************");
                mensajeIngresado = Console.ReadLine();
                while (!int.TryParse(mensajeIngresado, out opcion))
                {
                    Console.WriteLine("Error. Debe ingresar una opción.");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                }
                if (opcion < 14 && opcion > 0)
                {
                    string mensaje = string.Empty;
                    switch (opcion)
                    {
                        case 1:
                            try
                            {
                                Customers customers = new Customers();
                                customers = AltaCustomer.AltaCliente(customers, mensaje);
                                customersLogics.Add(customers);
                            }catch(CustomException ex)
                            {
                                Console.WriteLine($"No se pudo hacer el alta - {ex.Message}");
                            }
                            break;
                        case 2:
                            try
                            {
                                Orders order = new Orders();
                                order = AltaOrder.AltaOrders(order, mensaje);
                                ordersLogics.Add(order);
                                
                            }catch(CustomException ex)
                            {
                                Console.WriteLine($"No se pudo hacer el alta - {ex.Message}");
                            }
                            break;
                        case 3:
                            try
                            {
                                Shippers shipper = new Shippers();
                                shipper = AltaShipper.AltaShippers(shipper, mensaje);
                                shippersLogics.Add(shipper);
                            }catch(CustomException ex)
                            {
                                Console.WriteLine($"No se pudo hacer el alta - {ex.Message}");
                            }

                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Que customer quiere dar de baja [id]");
                                mensaje = Console.ReadLine();
                                numeroId = int.Parse(mensaje);
                                customersLogics.Delete(numeroId);
                            }catch(CustomException ex)
                            {
                                Console.WriteLine($"No se pudo dar de baja {mensaje} - {ex.Message}");
                            }
                            break;
                        case 5:
                            try
                            {
                                Console.WriteLine("Que orders quiere dar de baja [id]");
                                mensaje = Console.ReadLine();
                                numeroId = int.Parse(mensaje);
                                ordersLogics.Delete(numeroId);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine($"No se pudo dar de baja {mensaje} - {ex.Message}");
                            }
                            break;
                        case 6:
                            try
                            {
                                Console.WriteLine("Que shippers quiere dar de baja [id]");
                                mensaje = Console.ReadLine();
                                numeroId = int.Parse(mensaje);
                                shippersLogics.Delete(numeroId);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine($"No se pudo dar de baja {mensaje} - {ex.Message}");
                            }
                            break;
                        case 7:
                            try
                            {
                                Customers customers = new Customers();
                                customers = AltaCustomer.AltaCliente(customers, mensaje);
                                customersLogics.Update(customers);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine($"No se pudo modificar - {ex.Message}");
                            }
                            break;
                        case 8:
                            try
                            {
                                Orders order = new Orders();
                                order = AltaOrder.AltaOrders(order, mensaje);
                                ordersLogics.Update(order);
                            }catch(CustomException ex)
                            {
                                Console.WriteLine($"No se pudo modificar - {ex.Message}");
                            }
                            break;
                        case 9:
                            try
                            {
                                Shippers shipper = new Shippers();
                                shipper = AltaShipper.AltaShippers(shipper, mensaje);
                                shippersLogics.Update(shipper);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine($"No se pudo modificar - {ex.Message}");
                            }
                            break;
                        case 10:

                            foreach (Customers customer in customersLogics.GetAll())
                            {
                                Console.WriteLine($"{customer.ContactName} - {customer.Country} - {customer.CompanyName}");
                            }
                            break;
                        case 11:
                            try
                            {
                                foreach (Orders order in ordersLogics.GetAll())
                                {
                                    Console.WriteLine($"{order.EmployeeID} - {order.CustomerID} - {order.OrderID}");
                                }
                            }catch(Exception ex)
                            {
                                Console.WriteLine($"No se pudo mostrar - {ex.Message}- {ex.InnerException}");
                            }

                            break;
                        case 12:
                            foreach (Shippers shipper in shippersLogics.GetAll())
                            {
                                Console.WriteLine($"{shipper.CompanyName} - {shipper.Phone} - {shipper.ShipperID}");
                            }
                            break;
                        case 13:
                            Console.WriteLine("¿Queres salir de la app?[Si/No]");
                            datoIngresado = Console.ReadLine();
                            if (datoIngresado == "si" || datoIngresado == "Si" || datoIngresado == "SI")
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            Console.WriteLine("entraste en la opcion incorrecta!");
                            break;
                    }
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (mensajeIngresado.ToLower() != "salir");

            Console.ReadKey();
        }
    
    }
}
