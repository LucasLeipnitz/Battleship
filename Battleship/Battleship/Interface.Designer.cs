using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.Table = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.twoPointsLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.Location = new System.Drawing.Point(204, 48);
            this.Table.MinimumSize = new System.Drawing.Size(350, 260);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(350, 260);
            this.Table.TabIndex = 0;
            this.Table.Text = "Mesa";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(755, 478);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(343, 338);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(25, 20);
            this.xTextBox.TabIndex = 2;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(394, 338);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(25, 20);
            this.yTextBox.TabIndex = 3;
            // 
            // twoPointsLabel
            // 
            this.twoPointsLabel.AutoSize = true;
            this.twoPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.twoPointsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPointsLabel.Location = new System.Drawing.Point(374, 338);
            this.twoPointsLabel.Name = "twoPointsLabel";
            this.twoPointsLabel.Size = new System.Drawing.Size(15, 19);
            this.twoPointsLabel.TabIndex = 4;
            this.twoPointsLabel.Text = ":";
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(344, 364);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 5;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 477);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.twoPointsLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.pictureBox);
            this.Name = "Interface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void InitializeTable()
        {
            // 
            // x and y coordinates
            //
            int xlocation = init_x;
            int ylocation = init_y;
            for (int i = 0; i < table_size; i++)
            {
                //x coordinates
                this.xcoordinates[i] = new System.Windows.Forms.Label();
                this.xcoordinates[i].AutoSize = true;
                this.xcoordinates[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.xcoordinates[i].Location = new System.Drawing.Point(xlocation, init_y + 15);
                this.xcoordinates[i].Name = "xcoordinates" + (i + 1).ToString();
                this.xcoordinates[i].Size = new System.Drawing.Size(21, 15);
                this.xcoordinates[i].TabIndex = 0;
                this.xcoordinates[i].BringToFront();
                //y coordinates
                this.ycoordinates[i] = new System.Windows.Forms.Label();
                this.ycoordinates[i].AutoSize = true;
                this.ycoordinates[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.ycoordinates[i].Location = new System.Drawing.Point(init_x - 21, ylocation);
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
            ylocation = init_y;
            for (int i = 0; i < table_size; i++)
            {
                xlocation = init_x;
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
        private int init_x = 250;
        private int init_y = 275;
        private System.Windows.Forms.Label[] ycoordinates = new System.Windows.Forms.Label[16];
        private System.Windows.Forms.Label[] xcoordinates = new System.Windows.Forms.Label[16];
        private System.Windows.Forms.Label[,] tcoordinates = new System.Windows.Forms.Label[16, 16];
        private System.Windows.Forms.Label Table;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label twoPointsLabel;
        private System.Windows.Forms.Button launchButton;
    }
}

