using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class CustomException : Exception
    {
        public CustomException(string mensaje) : base(mensaje)
        {

        }

        public CustomException(string mensaje,Exception inerException) : base(mensaje, inerException)
        {

        }
    }
}
