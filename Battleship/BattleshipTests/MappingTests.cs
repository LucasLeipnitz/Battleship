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
            bool[,] isShip = new bool[16, 16];
            for(int i = 0; i < 16; i++){
                for (int j = 0; j < 16; j++){
                    isShip[i, j] = false;
                }
            }
            isShip[1, 7] = true;
            isShip[1, 8] = true;
            isShip[1, 9] = true;
            isShip[12, 3] = true;
            isShip[13, 3] = true;
            isShip[14, 3] = true;
            isShip[8, 11] = true;
            isShip[8, 12] = true;
            isShip[8, 13] = true;
            Mapping map = new Mapping(isShip,16);

            // Assert
            // Miss
            Assert.AreEqual(0, map.LaunchCheck(0, 0));
            Assert.AreEqual(0, map.LaunchCheck(0, 5));
            Assert.AreEqual(0, map.LaunchCheck(0, 13));

            // Hit
            Assert.AreEqual(1, map.LaunchCheck(1, 8));

            // Invalid
            Assert.AreEqual(2, map.LaunchCheck(0, 16));
            Assert.AreEqual(2, map.LaunchCheck(16, 0));
            Assert.AreEqual(2, map.LaunchCheck(3185, 250));


        }
    }
}
