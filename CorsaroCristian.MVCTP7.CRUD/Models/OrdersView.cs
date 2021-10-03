using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorsaroCristian.MVCTP7.Models
{
    public class OrdersView
    {
        public int Id
        {
            get;
            set;
        }

        public decimal Freight { get; set; }

        public DateTime OrderDate { get; set; }
    }
}