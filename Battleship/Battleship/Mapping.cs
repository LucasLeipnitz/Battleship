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
        private int shipNumber;
        private int remainingShips;

        public Mapping(bool[,] generatedMap, int tableSize, int shipNumber){
            isShip = generatedMap;
            this.tableSize = tableSize;
            this.shipNumber = shipNumber;
            remainingShips = shipNumber;
        }

        private int Invalid => 2;
        private int Hit => 1;
        private int Miss => 0;

        public int LaunchCheck(int xcoordinates, int ycoordinates){
            if (xcoordinates >= tableSize || ycoordinates >= tableSize
                || xcoordinates < 0 || ycoordinates < 0){
                return Invalid;
            }else{
                if (isShip[xcoordinates, ycoordinates]){
                    remainingShips--;
                    return Hit;
                }
                else{
                    return Miss;
                }
            }
        }

        public int GetRemainingShips(){
            return remainingShips;
        }

        public void RestartGame(){
            remainingShips = shipNumber;
        }
    }
}
