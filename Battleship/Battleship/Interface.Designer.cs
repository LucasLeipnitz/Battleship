namespace Battleship
{
    partial class Interface
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
        private void InitializeTable()
        {
            // 
            // x and y coordinates
            //
            int xlocation = 192;
            int ylocation = 297;
            for (int i = 0; i < table_size; i++)
            {
                //x coordinates
                this.xcoordinates[i] = new System.Windows.Forms.Label();
                this.xcoordinates[i].AutoSize = true;
                this.xcoordinates[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.xcoordinates[i].Location = new System.Drawing.Point(xlocation, 312);
                this.xcoordinates[i].Name = "xcoordinates" + (i + 1).ToString();
                this.xcoordinates[i].Size = new System.Drawing.Size(21, 15);
                this.xcoordinates[i].TabIndex = 0;
                //y coordinates
                this.ycoordinates[i] = new System.Windows.Forms.Label();
                this.ycoordinates[i].AutoSize = true;
                this.ycoordinates[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.ycoordinates[i].Location = new System.Drawing.Point(171, ylocation);
                this.ycoordinates[i].Name = "ycoordinates" + (i + 1).ToString();
                this.ycoordinates[i].Size = new System.Drawing.Size(21, 15);
                this.ycoordinates[i].TabIndex = 0;
                //remnant
                if (i + 1 < 10)
                {
                    this.ycoordinates[i].Text = "0" + (i + 1).ToString();
                    this.xcoordinates[i].Text = "0" + (i + 1).ToString();
                }
                else
                {
                    this.ycoordinates[i].Text = (i + 1).ToString();
                    this.xcoordinates[i].Text = (i + 1).ToString();
                }
                ylocation = ylocation - 15;
                xlocation = xlocation + 18;
                this.Controls.Add(this.ycoordinates[i]);
                this.Controls.Add(this.xcoordinates[i]);
            }

            // 
            // table coordinates
            //
            ylocation = 297;
            for (int i = 0; i < table_size; i++)
            {
                xlocation = 192;
                for (int j = 0; j < table_size; j++)
                {
                    this.tcoordinates[i, j] = new System.Windows.Forms.Label();
                    this.tcoordinates[i, j].AutoSize = true;
                    this.tcoordinates[i, j].BackColor = System.Drawing.Color.Blue;
                    this.tcoordinates[i, j].Location = new System.Drawing.Point(xlocation, ylocation);
                    this.tcoordinates[i, j].MinimumSize = new System.Drawing.Size(21, 15);
                    this.tcoordinates[i, j].Name = "x" + (i + 1).ToString() + "y" + (j + 1).ToString();
                    this.tcoordinates[i, j].Size = new System.Drawing.Size(21, 15);
                    this.tcoordinates[i, j].TabIndex = 0;
                    this.tcoordinates[i, j].Text = " ";
                    xlocation = xlocation + 18;
                    this.Controls.Add(this.tcoordinates[i, j]);
                }
                ylocation = ylocation - 15;
            }
        }

        private int table_size = 16;
        private System.Windows.Forms.Label[] ycoordinates = new System.Windows.Forms.Label[16];
        private System.Windows.Forms.Label[] xcoordinates = new System.Windows.Forms.Label[16];
        private System.Windows.Forms.Label[,] tcoordinates = new System.Windows.Forms.Label[16, 16];
    }
}

