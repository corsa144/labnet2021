using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    public class AltaOrder
    {
        public static Orders AltaOrders(Orders order, string mensaje)
        {
            order = new Orders();
            decimal dinero;
            int numero;
            Console.WriteLine("Ingrese orderDate [fecha]:");
            mensaje = Console.ReadLine();
            DateTime parsedDate = DateTime.Parse(mensaje);
            order.OrderDate = parsedDate;

            Console.WriteLine("Ingrese RequiredDate [fecha]:");
            mensaje = Console.ReadLine();
            parsedDate = DateTime.Parse(mensaje);
            order.RequiredDate = parsedDate;

            Console.WriteLine("Ingrese ShippedDate [fecha]:");
            mensaje = Console.ReadLine();
            parsedDate = DateTime.Parse(mensaje);
            order.ShippedDate = parsedDate;

            Console.WriteLine("Ingrese ShipVia [numero]:");
            mensaje = Console.ReadLine();
            numero = int.Parse(mensaje);
            order.ShipVia = numero;

            Console.WriteLine("Ingrese Freight [numero]:");
            mensaje = Console.ReadLine();
            dinero = decimal.Parse(mensaje);
            order.Freight = numero;

            Console.WriteLine("Ingrese ShipName [nombre]:");
            mensaje = Console.ReadLine();
            order.ShipName = mensaje;

            Console.WriteLine("Ingrese ShipAdress [direccion]:");
            mensaje = Console.ReadLine();
            order.ShipAddress = mensaje;

            Console.WriteLine("Ingrese ShipCity [ciudad]:");
            mensaje = Console.ReadLine();
            order.ShipCity = mensaje;

            Console.WriteLine("Ingrese ShipRegion [region]:");
            mensaje = Console.ReadLine();
            order.ShipRegion = mensaje;

            Console.WriteLine("Ingrese ShipPostalCode [codigo postal]:");
            mensaje = Console.ReadLine();
            order.ShipPostalCode = mensaje;

            Console.WriteLine("Ingrese ShipCountry [estado]:");
            mensaje = Console.ReadLine();
            order.ShipCountry = mensaje;

            Console.WriteLine("Ingrese CustomerId [letras]:");
            mensaje = Console.ReadLine();
            order.CustomerID = mensaje;

            Console.WriteLine("Ingrese EmpleyeeId [numero]:");
            mensaje = Console.ReadLine();
            numero = int.Parse(mensaje);
            order.EmployeeID = numero;

            return order;
        }
    }
}
