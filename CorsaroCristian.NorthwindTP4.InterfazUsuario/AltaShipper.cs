using CorsaroCristian.NorthwindTP4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.InterfazUsuario
{
    public class AltaShipper
    {
        public static Shippers AltaShippers(Shippers shipper, string mensaje)
        {
            shipper = new Shippers();
            Console.WriteLine("Ingrese CompanyName [compania]:");
            mensaje = Console.ReadLine();
            shipper.CompanyName = mensaje;

            Console.WriteLine("Ingrese Phone [telefono]:");
            mensaje = Console.ReadLine();
            shipper.Phone = mensaje;

            return shipper;
        }
    }
}
