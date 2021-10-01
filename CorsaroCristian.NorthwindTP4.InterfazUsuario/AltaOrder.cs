using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorsaroCristian.NorthwindTP4.Logica;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    public class AltaOrder
    {
        public static Orders AltaOrders(Orders order, string mensaje)
        {
            order = new Orders();
            decimal dinero;
            int numero;
            do
            {
                Console.WriteLine("Ingrese orderDate [fecha]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsDate(mensaje));

            DateTime parsedDate = DateTime.Parse(mensaje);
            order.OrderDate = parsedDate;
            do
            {
                Console.WriteLine("Ingrese RequiredDate [fecha]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsDate(mensaje));

            parsedDate = DateTime.Parse(mensaje);
            order.RequiredDate = parsedDate;
            do
            {
                Console.WriteLine("Ingrese ShippedDate [fecha]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsDate(mensaje));

            parsedDate = DateTime.Parse(mensaje);
            order.ShippedDate = parsedDate;
            do
            {
                Console.WriteLine("Ingrese ShipVia [numero]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsNumber(mensaje));

            numero = int.Parse(mensaje);
            order.ShipVia = numero;
            do
            {
                Console.WriteLine("Ingrese Freight [numero]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsFloat(mensaje));

            dinero = decimal.Parse(mensaje);
            order.Freight = numero;
            do
            {
                Console.WriteLine("Ingrese ShipName [nombre]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 40));

            order.ShipName = mensaje;
            do
            {
                Console.WriteLine("Ingrese ShipAdress [direccion]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 60));

            order.ShipAddress = mensaje;
            do
            {
                Console.WriteLine("Ingrese ShipCity [ciudad]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));

            order.ShipCity = mensaje;
            do
            {
                Console.WriteLine("Ingrese ShipRegion [region]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));

            order.ShipRegion = mensaje;
            do
            {
                Console.WriteLine("Ingrese ShipPostalCode [codigo postal]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 10));

            order.ShipPostalCode = mensaje;
            do
            {
                Console.WriteLine("Ingrese ShipCountry [estado]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));

            order.ShipCountry = mensaje;
            do
            {
                Console.WriteLine("Ingrese CustomerId [letras]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 5));
            order.CustomerID = mensaje;
            do
            {
                Console.WriteLine("Ingrese EmpleyeeId [numero]:");
                mensaje = Console.ReadLine();
            } while (!Validations.IsNumber(mensaje));

            numero = int.Parse(mensaje);
            order.EmployeeID = numero;

            return order;
        }
    }
}
