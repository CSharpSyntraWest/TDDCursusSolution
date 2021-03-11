using NUnit.Framework;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    public class Tests
    {
        [Test]
        public void EenJaarDeelbaarDoor400IsEenSchrikkeljaar()
        {
            //Voorbeeld volgens Design pattern 3A (AAA):
            //Arrange: initialisaties opzetten
            Jaar testJaar = new Jaar(2000);
            //Act: aanroepen van de te testen unit
            bool result = testJaar.IsSchrikkeljaar;  //Unit is hier IsSchrikkeljaar
            //Assert: uitkomst van de unit vergelijken met het verwachte resultaat
            Assert.AreEqual(true,result);
        }

    }
}