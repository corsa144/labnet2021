using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorsaroCristian.NorthwindTP4.Datos;
using Moq;
using CorsaroCristian.NorthwindTP4.Logica;
using Engine.Moq;
using CorsaroCristian.NorthwindTP4.Entidades;

namespace TestEngine.Moq.ManualMock
{
    [TestClass]
    public class TestPlayer
    {
        // Should receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            //Player player = Player.CreateNewPlayer("");
            Shippers shipper = new Shippers();
        }

        // Should still receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            ShippersLogic sl = new ShippersLogic();
            Shippers s = new Shippers();
        }

        // Should receive an exception, because we set the mock PlayerDataMapper 
        // to say the player name already exists in the database.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = true;

            Shippers shippers = new Shippers();
        }

        // Should succeed, because we set the mock PlayerDataMapper 
        // to say the player name does not already exist in the database.
        // Also, when it calls the mock InsertNewPlayerIntoDatabase,
        // the mock mapper will not need a database running.
        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = false;

            ShippersLogic sl = new ShippersLogic();
            Shippers s = new Shippers();
            s.ShipperID = 4;
            s.CompanyName = "Speedy Express";
            s.Phone = "(503) 555-9831";
            sl.Add(s);

            Assert.AreEqual("Speedy Express", s.CompanyName);
            Assert.AreEqual("(503) 555-9831", s.Phone);
        }

        // Should receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName2()
        {
            Shippers shipper = new Shippers();
            shipper.CompanyName = "";
            shipper.Phone = "1234556778";
        }

        // Should still receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper2()
        {
            var mock = new Mock<IPlayerDataMapper>();

            Shippers shipper = new Shippers();
            shipper.CompanyName = "";
            shipper.Phone = "2345673411";
        }

        // Should receive an exception, because we set the mock PlayerDataMapper 
        // to say the player name already exists in the database.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase2()
        {
            var mock = new Mock<IPlayerDataMapper>();
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<int>(),It.IsAny<string>(),It.IsAny<string>())).Returns(true);

            Shippers shipper = new Shippers();
            shipper.CompanyName = "Neoris";
            shipper.Phone = "49180987";
        }

        // Should succeed, because we set the mock PlayerDataMapper 
        // to say the player name does not already exist in the database.
        // Also, when it calls the mock InsertNewPlayerIntoDatabase,
        // the mock mapper will not need a database running.
        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase2()
        {
            var mock = new Mock<IPlayerDataMapper>();
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            //Player player = Player.CreateNewPlayer("Test", mock.Object);
            Shippers shipper = new Shippers();
            shipper.CompanyName = mock.Object.ToString();
            Assert.AreEqual("Test", shipper.CompanyName);

        }
    }
}
