using Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext northwindContext;

        public BaseLogic()
        {
            northwindContext = new NorthwindContext();
        }
    }
}
