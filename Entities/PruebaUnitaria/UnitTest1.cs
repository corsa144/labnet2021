using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Linq.Data;
using Linq.Entities;
using Linq.Logic;
using System.Collections.Generic;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             protected readonly NorthwindContext northwindContext = new NorthwindContext();
             List<Customers> context = northwindContext.Customers.ToList();
        }
    }
}
