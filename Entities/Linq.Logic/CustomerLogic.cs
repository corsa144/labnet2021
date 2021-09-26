using Linq.Data;
using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class CustomerLogic 
    {
        //List<Customers> customers;
        protected readonly NorthwindContext northwindContext = new NorthwindContext();
        //object variable;
 
        //public List<Customers> customersList;
        /*List<string> my_list = new List<string>() {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
        };*/
        public static readonly IEnumerable<Customers> my_list1 = new List<Customers>();
       
        //private static readonly List<Customers> my_list2 = my_list1;
        // Creating LINQ Query
        // Using Method syntax
        //object res = my_list1.Where(a => a.Contains("Dog"));
        //Customers customer = new Customers();
        //List<Customers> customers = new List<Customers>();
        public CustomerLogic()
        {
   
            //my_list1 = this.GetAll();
            //variable = this.my_list1;
            //my_list2 = new NorthwindContext();
            //customers = new List<Customers>();
            //customers = this.GetAll();
        }
        
        CustomerLogic queryUno = new CustomerLogic();
        /* Customers query = from customer in customers
                           where customer.ContactName is "Maria Anders"
                           select customer;
        */

        public object query = my_list1.Where(c => c.ContactName.Contains("Maria Anders"));

        public List<Customers> GetAll()
        {
            return northwindContext.Customers.ToList();
        }
    }
}
