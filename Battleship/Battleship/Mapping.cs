using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Mapping{

        private bool[,] isShip = new bool[16, 16];

        public Mapping(bool[,] generatedMap){
            isShip = generatedMap;
        }

        private bool Hit => true;
        private bool Miss => false;

        public bool LaunchCheck(int xcoordinates, int ycoordinates){
            if (isShip[xcoordinates, ycoordinates]){
                return Hit;
            }else{
                return Miss;
            }
        }

    }
}
