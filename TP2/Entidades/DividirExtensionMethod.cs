using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DividirExtensionMethod
    {
        public static float DividirEnteros(this int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    }
}
