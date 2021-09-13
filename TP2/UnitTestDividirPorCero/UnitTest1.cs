using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTestDividirPorCero
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void CompruebaLanzamientodeCustomExceptionTest()
        {
            //Arrange
            int numero = 20;

            //Act
            Logic.Dividir(numero);
            //Assert 

        }

        [TestMethod]
        public void DividirExtensionMethodTest()
        {
            //arrange
            int dividendo = 20;
            int divisor = 2;
            int resultado;
            //act
            resultado = DividirExtensionMethod.DividirEnteros(dividendo, divisor);
            //assert
            Assert.AreEqual(resultado, 10);
        }
    }
}
