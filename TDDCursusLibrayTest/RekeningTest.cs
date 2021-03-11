using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    public class RekeningTest
    {
        private Rekening rekening;
        [SetUp]
        public void Initialiseer()
        {
            //Arrange
            rekening= new Rekening();
        }
        [Test]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            //Arrange
           // Rekening rekening = new Rekening();
            //Act
            decimal resultaat = rekening.Saldo; //Unit is Saldo
            //Assert
            Assert.AreEqual(decimal.Zero, resultaat);
        }
        [Test]
        public void HetSaldoNaEenEersteStortingIsHetBedragVanDieStorting()
        {
            //Arrange
            //Rekening rekening = new Rekening(); //rekening is "SUT" of Sytem Under Test
            decimal testBedrag = 2000.55m;
            //Act
            rekening.Storten(testBedrag);
            decimal eindSaldo = rekening.Saldo;
            //Assert
            Assert.AreEqual(testBedrag, eindSaldo);
        }
        [Test]
        public void HetSaldoNaTweeStortingenIsDeSomVanDeBedragenVanDieStorting()
        {
            //Oefening: vul de test methode code aan:
            //Arrange
           // Rekening rekening = new Rekening();
            decimal testBedrag1 = 100.50m;
            decimal testBedrag2 = 50.55m;
            //Act
            rekening.Storten(testBedrag1);
            rekening.Storten(testBedrag2);
            decimal eindSaldo = rekening.Saldo;
            //Assert
            Assert.AreEqual(testBedrag1 + testBedrag2, eindSaldo);
        }
        [Test]
        public void EenNegatiefBedragStortenGeeftEenArgumentException()
        {
            //Arrange
           // Rekening rekening = new Rekening();
            decimal testBedrag = -100.50m;
            
            //Act + Assert
            Assert.Throws<ArgumentException>(() => rekening.Storten(testBedrag));

        }
     
    }
}
