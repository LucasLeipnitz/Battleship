using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Interface : Form
    {
        private Mapping map;

        public Interface()
        {
            InitializeComponent();
            InitializeTable();

            //Teste de mapa antes do gerador de mapa
            map = MapGenerator.MapGenerate1();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            pictureBox.BringToFront();
            pictureBox.Controls.Add(xTextBox);
            pictureBox.Controls.Add(yTextBox);
            pictureBox.Controls.Add(twoPointsLabel);
            pictureBox.Controls.Add(launchButton);
            for (int i = 0; i < table_size; i++)
            {
                pictureBox.Controls.Add(xcoordinates[i]);
                pictureBox.Controls.Add(ycoordinates[i]);
            }
            for (int i = 0; i < table_size; i++)
            {
                for (int j = 0; j < table_size; j++)
                {
                    pictureBox.Controls.Add(tcoordinates[i,j]);
                }
            }

        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            int x,y;
            if (int.TryParse(xTextBox.Text, out x) && int.TryParse(yTextBox.Text, out y)) {
                int op = map.LaunchCheck(x - 1, y - 1);
                switch (op)
                {
                    case 0:
                        tcoordinates[x - 1, y - 1].BackColor = System.Drawing.Color.Green;
                        break;
                    case 1:
                        tcoordinates[x - 1, y - 1].BackColor = System.Drawing.Color.Red;
                        if (map.GetRemainingShips() == 0){
                            for(int i = 0; i < table_size; i++){
                                for (int j = 0; j < table_size; j++)
                                {
                                    tcoordinates[i, j].BackColor = System.Drawing.Color.Blue;
                                }
                            }
                        }
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
