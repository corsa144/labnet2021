using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Logic;

namespace Linq.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 CustomerLogic c = new CustomerLogic();
                /* foreach(var item in (IEnumerable)c.query)
                 {
                     Console.WriteLine($"{item}");
                 }*/
                Console.WriteLine("No falle");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
   
            Console.ReadLine();
        }
    }
}
