using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CustomException :Exception
    {
        public CustomException(string mensaje) : base(mensaje)
        {

        }

        public CustomException(string mensaje, Exception innerException):base(mensaje, innerException)
        {

        }
    }
}
