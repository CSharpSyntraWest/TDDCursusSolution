using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    [TestFixture]
    public class VeilingTest
    {
        private Veiling veiling;
        [SetUp]
        public void Initialiseer()
        {
            //Arrange
            veiling = new Veiling();
        }
        [Test]
        public void HetHoogsteBodVanEenNieuweVeilingStaatOpNul()
        {
            //Act
            decimal resultaat = veiling.HoogsteBod;
            //Assert
            Assert.AreEqual(0m, resultaat);
        }
        [Test]
        public void NaEenEersteBodIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            //Arrange - vervolg
            decimal testBedrag = 100.55m;
            //Act
            veiling.DoeBod(testBedrag);
            decimal resultaat = veiling.HoogsteBod;
            //Assert
            Assert.AreEqual(testBedrag, resultaat);
        }
        [Test]
        public void NaMeerdereBiedingenIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            //Act
            veiling.DoeBod(100.55m);
            veiling.DoeBod(200.00m);
            veiling.DoeBod(150.66m);
            //Assert
            Assert.AreEqual(200.00m, veiling.HoogsteBod);
        }
        [Test]
        public void EenNegatiefBodMoetEenArgumentExceptionGeven()
        { 
            //In te vullen en indien nodig code in Veiling class aanpassen
        }
    }
}
