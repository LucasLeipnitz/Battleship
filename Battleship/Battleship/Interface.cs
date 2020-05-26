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
        public Interface()
        {
            InitializeComponent();
            InitializeTable();
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
    }
}
