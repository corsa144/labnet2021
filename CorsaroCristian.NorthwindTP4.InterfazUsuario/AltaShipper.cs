using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorsaroCristian.NorthwindTP4.Logica;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    public class AltaShipper
    {
        public static Shippers AltaShippers(Shippers shipper, string mensaje)
        {
            shipper = new Shippers();
            do
            {
                Console.WriteLine("Ingrese CompanyName [compania]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 40));

            shipper.CompanyName = mensaje;
            do
            {
                Console.WriteLine("Ingrese Phone [telefono]:");
                mensaje = Console.ReadLine();
            } while (!Validations.ValidateStringLength(mensaje, 24));

            shipper.Phone = mensaje;

            return shipper;
        }
    }
}
