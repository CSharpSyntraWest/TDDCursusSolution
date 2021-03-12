using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    public class DegreeConverterTests
    {
        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            //Arrange
            DegreeConverter converter = new DegreeConverter(); //is SUT
            //Act
            double result = converter.ToFahrenheit(0);
            //Assert
            Assert.That(result, Is.EqualTo(32)); //Contraints assertions model

            //Assert.AreEqual(result, 32);// of Klassieke assertions model
        }
        [Test]
        public void ToCelsius_1Fahrenheit_Returns0()
        {
            //Arrange
            DegreeConverter converter = new DegreeConverter(); //is SUT
            //Act
            double result = converter.ToCelsius(1);
            //Assert
            Assert.That(result, Is.EqualTo(0)); //Contraints assertions model
            //Assert.AreEqual(result, 0);// of Klassieke assertions model
        }
    }
}
