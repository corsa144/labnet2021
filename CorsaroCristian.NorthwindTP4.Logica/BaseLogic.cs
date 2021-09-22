using CorsaroCristian.NorthwindTP4.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class BaseLogic
    {
        protected readonly NorthwindContext contexto;

        public BaseLogic()
        {
            contexto = new NorthwindContext();
        }
    }
}
