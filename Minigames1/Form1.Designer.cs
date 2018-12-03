using System.Drawing;

namespace Minigames1
{
    partial class miniGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniGames));
            this.minePic = new System.Windows.Forms.PictureBox();
            this.ticTacToe = new System.Windows.Forms.PictureBox();
            this.mineSweeper = new System.Windows.Forms.Label();
            this.battleShips = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shipPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).BeginInit();
            this.SuspendLayout();
            // 
            // minePic
            // 
            this.minePic.BackColor = System.Drawing.Color.Transparent;
            this.minePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minePic.Image = ((System.Drawing.Image)(resources.GetObject("minePic.Image")));
            this.minePic.Location = new System.Drawing.Point(94, 63);
            this.minePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minePic.Name = "minePic";
            this.minePic.Size = new System.Drawing.Size(144, 128);
            this.minePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minePic.TabIndex = 1;
            this.minePic.TabStop = false;
            this.minePic.Click += new System.EventHandler(this.minePic_Click);
            // 
            // ticTacToe
            // 
            this.ticTacToe.BackColor = System.Drawing.Color.Transparent;
            this.ticTacToe.Location = new System.Drawing.Point(408, 244);
            this.ticTacToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticTacToe.Name = "ticTacToe";
            this.ticTacToe.Size = new System.Drawing.Size(140, 119);
            this.ticTacToe.TabIndex = 4;
            this.ticTacToe.TabStop = false;
            // 
            // mineSweeper
            // 
            this.mineSweeper.AutoSize = true;
            this.mineSweeper.BackColor = System.Drawing.Color.Transparent;
            this.mineSweeper.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.mineSweeper.ForeColor = System.Drawing.Color.MediumBlue;
            this.mineSweeper.Location = new System.Drawing.Point(103, 178);
            this.mineSweeper.Name = "mineSweeper";
            this.mineSweeper.Size = new System.Drawing.Size(123, 23);
            this.mineSweeper.TabIndex = 5;
            this.mineSweeper.Text = "Minesweeper\r\n";
            // 
            // battleShips
            // 
            this.battleShips.AutoSize = true;
            this.battleShips.BackColor = System.Drawing.Color.Transparent;
            this.battleShips.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.battleShips.ForeColor = System.Drawing.Color.MediumBlue;
            this.battleShips.Location = new System.Drawing.Point(427, 178);
            this.battleShips.Name = "battleShips";
            this.battleShips.Size = new System.Drawing.Size(103, 23);
            this.battleShips.TabIndex = 6;
            this.battleShips.Text = "Battleships";
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.titlu.ForeColor = System.Drawing.Color.MediumBlue;
            this.titlu.Location = new System.Drawing.Point(134, 9);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(396, 23);
            this.titlu.TabIndex = 7;
            this.titlu.Text = "Apasati pe jocul pe care doriti sa il deschideti!";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(94, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 119);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // shipPic
            // 
            this.shipPic.BackColor = System.Drawing.Color.Transparent;
            this.shipPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shipPic.Image = ((System.Drawing.Image)(resources.GetObject("shipPic.Image")));
            this.shipPic.Location = new System.Drawing.Point(408, 63);
            this.shipPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipPic.Name = "shipPic";
            this.shipPic.Size = new System.Drawing.Size(140, 128);
            this.shipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shipPic.TabIndex = 3;
            this.shipPic.TabStop = false;
            this.shipPic.Click += new System.EventHandler(this.shipPic_Click);
            // 
            // miniGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.battleShips);
            this.Controls.Add(this.mineSweeper);
            this.Controls.Add(this.shipPic);
            this.Controls.Add(this.ticTacToe);
            this.Controls.Add(this.minePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "miniGames";
            this.Text = "Minigames";
            ((System.ComponentModel.ISupportInitialize)(this.minePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox minePic;
        private System.Windows.Forms.PictureBox ticTacToe;
        private System.Windows.Forms.Label mineSweeper;
        private System.Windows.Forms.Label battleShips;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox shipPic;
    }
}
