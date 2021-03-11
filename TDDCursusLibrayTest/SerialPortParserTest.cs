using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    [TestFixture]
    public class SerialPortParserTest
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            //Act
            int result = SerialPortParser.ParsePort("COM1");
            //Assert
            Assert.That(result, Is.EqualTo(1)); // Contraint Assert Model Nunit
           // Assert.AreEqual(1, result);//Klassieke Assert Model NUnit
        }
    }
}
