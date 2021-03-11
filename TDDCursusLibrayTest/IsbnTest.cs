using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    public class IsbnTest
    {
        [Test]
        public void HetNummer0IsVerkeerd()
        {//vul de code aan…
         //moet ArgumentException geven als je constructor met getal 0 aanroept
         //Arrange + Act + Assert:
            Assert.Throws<ArgumentException>(() => new Isbn(0L));
        }
        [Test]
        public void EenNegatiefNummerIsVerkeerd()
        {//vul de code aan…
         //een Negatief nummer geeft ArgumentException (bv -9789027439642L)
         //Arrange + Act + Assert:
            Assert.Throws<ArgumentException>(() => new Isbn(-9789027439642L));
        }
        [Test]

        public void EenNummerMet12CijfersIsVerkeerd()
        {//vul de code aan…
         //978902743964L geeft ArgumentException terug
         //Arrange + Act + Assert:
            Assert.Throws<ArgumentException>(() => new Isbn(978902743964L));
        }
        [Test]
        public void EenNummerMet14CijfersIsVerkeerd()
        {//vul de code aan…
         //97890274396421L geeft ArgumentException
         //Arrange + Act + Assert:
            Assert.Throws<ArgumentException>(() => new Isbn(97890274396421L));
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal2()
        {//vul de code aan…
         //8789027439642L geeft argumentException
            Assert.Throws<ArgumentException>(() => new Isbn(8789027439642L));
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal2()
        {//vul de code aan…
         //ok 9789027439642L
         //Arrange
            long testNumber = 9789027439642L;
            Assert.AreEqual(testNumber.ToString(), new Isbn(testNumber).ToString());
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal0()
        {//vul de code aan…

            //7789227439640L geeft ArgumentException
            Assert.Throws<ArgumentException>(() => new Isbn(7789227439640L));
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {//vul de code aan…
         //ok
         //9789227439640L
         //Arrange
            long testNumber = 9789227439640L;
            //Act + Assert
            Assert.AreEqual(testNumber.ToString(), new Isbn(testNumber).ToString());
        }
    }
}