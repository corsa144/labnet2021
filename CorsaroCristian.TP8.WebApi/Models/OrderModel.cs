using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace CorsaroCristian.TP8.WebApi.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public float Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public Customers Customers { get; set; }
        public Shippers Shippers { get; set; }
    }

    public class Rootobject
    {
        public OrderModel[] Property1 { get; set; }
    }



    public class Customers
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public object[] Orders { get; set; }
        public Customerdemographic[] CustomerDemographics { get; set; }
    }

    public class Customerdemographic
    {
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public object[] Customers { get; set; }
    }

    public class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public object[] Orders { get; set; }
    }
}