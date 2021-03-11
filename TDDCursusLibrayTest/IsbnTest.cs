using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrayTest
{
    public class IsbnTest
    {
        [Test]
        public void HetNummer0IsVerkeerd()
        {//vul de code aan…
         //moet ArgumentException geven als je constructor met getal 0 aanroept
        }
        [Test]
        public void EenNegatiefNummerIsVerkeerd()
        {//vul de code aan…
         //een Negatief nummer geeft ArgumentException (bv -9789027439642L)

        }
        [Test]

        public void EenNummerMet12CijfersIsVerkeerd()
        {//vul de code aan…
         //978902743964L geeft ArgumentException terug
        }
        [Test]
        public void EenNummerMet14CijfersIsVerkeerd()
        {//vul de code aan…
         //97890274396421L geeft ArgumentException
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal2()
        {//vul de code aan…
         //8789027439642L geeft argumentException
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal2()
        {//vul de code aan…
         //ok 9789027439642L
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal0()
        {//vul de code aan…

            //7789227439640L geeft ArgumentException
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {//vul de code aan…
         //ok
         //9789227439640L
        }
    }
}