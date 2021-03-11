using NUnit.Framework;
using TDDCursusLibrary;

namespace TDDCursusLibrayTest
{
    [TestFixture]
    public class JaarTest
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
        [Test]
        public void EenJaarDeelbaarDoor100MaarNietDoor400IsGeenSchrikkeljaar()
        {
            //AAA
            //Arrange
            Jaar testJaar = new Jaar(1900);
            //Act
            bool result = testJaar.IsSchrikkeljaar;
            //Assert
            Assert.AreEqual(false, result);
        }
        [Test]
        public void EenJaarDeelbaarDoor4IsEenSchrikkeljaar()
        {
            //Arrange
            Jaar testJaar = new Jaar(2012);
            //Act
            bool result = testJaar.IsSchrikkeljaar;
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void EenJaarNietDeelbaarDoor4IsGeenSchrikkeljaar()
        {
            //Arrange
            Jaar testJaar = new Jaar(2015);
            //Act
            bool result = testJaar.IsSchrikkeljaar;
            //Assert
            Assert.IsFalse(result);
        }
    }
}