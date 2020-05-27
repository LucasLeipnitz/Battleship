using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Mapping{

        private bool[,] isShip = new bool[16, 16];
        private int tableSize;

        public Mapping(bool[,] generatedMap, int tableSize){
            isShip = generatedMap;
            this.tableSize = tableSize;
        }

        private int Invalid => 2;
        private int Hit => 1;
        private int Miss => 0;

        public int LaunchCheck(int xcoordinates, int ycoordinates){
            if (xcoordinates >= tableSize || ycoordinates >= tableSize){
                return Invalid;
            }else{
                if (isShip[xcoordinates, ycoordinates]){
                    return Hit;
                }
                else{
                    return Miss;
                }
            }
        }

    }
}
