using CorsaroCristian.NorthwindTP4.Entidades;
using CorsaroCristian.NorthwindTP4.Logica;
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
            do
            {
                Console.WriteLine("Ingrese CustomerId [5 letras]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 5));

            customers.CustomerID = mensaje;
            do
            {
                Console.WriteLine("Ingrese Adress [Direccion]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 60));

            customers.Address = mensaje;
            do
            {
                Console.WriteLine("Ingrese City [ciudad]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));
            customers.City = mensaje;
            do
            {
                Console.WriteLine("Ingrese CompanyName [compania]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 40));

            customers.CompanyName = mensaje;
            do
            {
                Console.WriteLine("Ingrese ContactName [conatacto]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 30));
            customers.ContactName = mensaje;
            do
            {
                Console.WriteLine("Ingrese ContactTitle [titulo]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 30));

            customers.ContactTitle = mensaje;
            do
            {
                Console.WriteLine("Ingrese Country [pais]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));
            customers.Country = mensaje;
            do
            {
                Console.WriteLine("Ingrese Fax:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 24));
            customers.Fax = mensaje;
            do
            {
                Console.WriteLine("Ingrese Phone [telefono]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 24));

            customers.Phone = mensaje;
            do
            {
                Console.WriteLine("Ingrese PostalCode [codigo postal]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 10));

            customers.PostalCode = mensaje;
            do
            {
                Console.WriteLine("Ingrese Region:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 15));

            customers.Region = mensaje;

            return customers;
        }
    }
}
