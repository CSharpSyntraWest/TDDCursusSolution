using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    public class WoordTest
    {

        //public void LepelIsEenPalindroom()
        [Test]
        public void IsPalindroom_Lepel_ReturnsTrue() // US naamconventie
        {
            //Arrange
            Woord woord = new Woord("lepel"); //woord is "SUT" - System Under Test
            //Act
            bool resultaat = woord.IsPalindroom(); //IsPalidroom is de Unit die wordt getest
            //Assert
            Assert.IsTrue(resultaat);
            //of
            //Assert.AreEqual(true, resultaat);
        }
        [Test]
        public void IsPalindroom_Vork_ReturnsFalse()
        {
            //Arrange
            Woord woord = new Woord("vork"); //woord is "SUT" - System Under Test
            //Act
            bool resultaat = woord.IsPalindroom(); //IsPalidroom is de Unit die wordt getest
            //Assert
            Assert.IsFalse(resultaat);
            //of
            //Assert.AreEqual(false, resultaat); 
        }
        [Test]
        public void IsPalidroom_LegeString_ReturnsTrue()
        {
            //Arrange
            Woord woord = new Woord(String.Empty); //woord is "SUT" - System Under Test
            //Act
            bool resultaat = woord.IsPalindroom(); //IsPalidroom is de Unit die wordt getest
            //Assert
            Assert.IsTrue(resultaat);
            //of
            //Assert.AreEqual(true, resultaat); 
        }
    }
}
