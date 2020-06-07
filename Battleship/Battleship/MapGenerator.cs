using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public static class MapGenerator{

        public static Mapping MapGenerate1()
        {
            Mapping map;
            bool[,] isShip = new bool[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
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
            map = new Mapping(isShip, 16, 9);
            return map;
        }
    }
}
