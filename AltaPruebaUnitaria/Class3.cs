using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorsaroCristian.NorthwindTP4.Entidades;
using CorsaroCristian.NorthwindTP4.Logica;
using Engine.Moq;

namespace TestEngine.Moq.ManualMock
{
    public class MockPlayerDataMapper : IPlayerDataMapper
    {
        // This property holds the value for PlayerNameExistsInDatabase to return.
        // This lets us "mock" the results that we would receive from a real database.
        public bool ResultToReturn { get; set; }

        // These functions implement the IPlayerDataMapper interface.
        public bool PlayerNameExistsInDatabase(int id, string phone, string companyName)
        {
            // This is whatever answer we need, for the current unit test.
            Shippers shipper = new Shippers();
            shipper.CompanyName = companyName;
            shipper.ShipperID = id;
            shipper.Phone = phone;

            return ResultToReturn;
        }

        public void InsertNewPlayerIntoDatabase(int id, string phone, string companyName)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            Shippers shipper = new Shippers();
            shipper.CompanyName = companyName;
            shipper.ShipperID = id;
            shipper.Phone = phone;
            shippersLogic.Add(shipper);
        }
    }
}
