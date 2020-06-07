using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship;

namespace BattleshipTests
{
    [TestClass]
    public class MappingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Mapping map = Battleship.MapGenerator.MapGenerate1();

            // Assert
            // Invalid
            Assert.AreEqual(2, map.LaunchCheck(0, 16));
            Assert.AreEqual(2, map.LaunchCheck(16, 0));
            Assert.AreEqual(2, map.LaunchCheck(3185, 250));
            Assert.AreEqual(2, map.LaunchCheck(-5, 0));
            Assert.AreEqual(2, map.LaunchCheck(0, -5)); ;
            Assert.AreEqual(2, map.LaunchCheck(-1, -2));
            //Check remaing ships with invalid shots
            Assert.AreEqual(9, map.GetRemainingShips());

            // Miss
            Assert.AreEqual(0, map.LaunchCheck(0, 0));
            Assert.AreEqual(0, map.LaunchCheck(0, 5));
            Assert.AreEqual(0, map.LaunchCheck(0, 13));
            Assert.AreEqual(0, map.LaunchCheck(7, 9));
            Assert.AreEqual(0, map.LaunchCheck(11, 15));
            //Check remaing ships with miss shots
            Assert.AreEqual(9, map.GetRemainingShips());

            // Hit
            Assert.AreEqual(1, map.LaunchCheck(1, 8));
            Assert.AreEqual(1, map.LaunchCheck(1, 9));
            Assert.AreEqual(1, map.LaunchCheck(12, 3));
            Assert.AreEqual(1, map.LaunchCheck(1, 8));//Repated
            Assert.AreEqual(1, map.LaunchCheck(8, 13));
            Assert.AreEqual(1, map.LaunchCheck(1, 8));//Repeated
            Assert.AreEqual(1, map.LaunchCheck(12, 3));//Repeated
            Assert.AreEqual(1, map.LaunchCheck(1, 8));//Repeated
            Assert.AreEqual(1, map.LaunchCheck(13, 3));
            Assert.AreEqual(1, map.LaunchCheck(1, 9));//Repeated
            //Check remaing ships with 5 repeated hits
            Assert.AreEqual(4, map.GetRemainingShips());
        }
    }
}
