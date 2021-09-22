using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    public class AltaCustomer
    {
        public static Customers AltaCliente(Customers customers, string mensaje)
        {
            customers = new Customers();

            Console.WriteLine("Ingrese CustomerId [5 letras]:");
            mensaje = Console.ReadLine();
            customers.CustomerID = mensaje;

            Console.WriteLine("Ingrese Adress [Direccion]:");
            mensaje = Console.ReadLine();
            customers.Address = mensaje;

            Console.WriteLine("Ingrese City [ciudad]:");
            mensaje = Console.ReadLine();
            customers.City = mensaje;

            Console.WriteLine("Ingrese CompanyName [compania]:");
            mensaje = Console.ReadLine();
            customers.CompanyName = mensaje;

            Console.WriteLine("Ingrese ContactName [conatacto]:");
            mensaje = Console.ReadLine();
            customers.ContactName = mensaje;

            Console.WriteLine("Ingrese ContactTitle [titulo]:");
            mensaje = Console.ReadLine();
            customers.ContactTitle = mensaje;

            Console.WriteLine("Ingrese Country [pais]:");
            mensaje = Console.ReadLine();
            customers.Country = mensaje;

            Console.WriteLine("Ingrese Fax:");
            mensaje = Console.ReadLine();
            customers.Fax = mensaje;

            Console.WriteLine("Ingrese Phone [telefono]:");
            mensaje = Console.ReadLine();
            customers.Phone = mensaje;

            Console.WriteLine("Ingrese PostalCode [codigo postal]:");
            mensaje = Console.ReadLine();
            customers.PostalCode = mensaje;

            Console.WriteLine("Ingrese Region:");
            mensaje = Console.ReadLine();
            customers.Region = mensaje;

            return customers;
        }
    }
}
