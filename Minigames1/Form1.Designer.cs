using System.Drawing;

namespace Minigames1
{
    partial class MiniGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniGames));
            this.MinePic = new System.Windows.Forms.PictureBox();
            this.ticTacToe = new System.Windows.Forms.PictureBox();
            this.mineSweeper = new System.Windows.Forms.Label();
            this.battleShips = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShipPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MinePic
            // 
            this.MinePic.BackColor = System.Drawing.Color.Transparent;
            this.MinePic.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.MinePic, "MinePic");
            this.MinePic.Name = "MinePic";
            this.MinePic.TabStop = false;
            this.MinePic.Click += new System.EventHandler(this.MinePic_Click);
            // 
            // ticTacToe
            // 
            this.ticTacToe.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ticTacToe, "ticTacToe");
            this.ticTacToe.Name = "ticTacToe";
            this.ticTacToe.TabStop = false;
            // 
            // mineSweeper
            // 
            resources.ApplyResources(this.mineSweeper, "mineSweeper");
            this.mineSweeper.BackColor = System.Drawing.Color.Transparent;
            this.mineSweeper.ForeColor = System.Drawing.Color.AliceBlue;
            this.mineSweeper.Name = "mineSweeper";
            // 
            // battleShips
            // 
            resources.ApplyResources(this.battleShips, "battleShips");
            this.battleShips.BackColor = System.Drawing.Color.Transparent;
            this.battleShips.ForeColor = System.Drawing.Color.AliceBlue;
            this.battleShips.Name = "battleShips";
            // 
            // titlu
            // 
            resources.ApplyResources(this.titlu, "titlu");
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.ForeColor = System.Drawing.Color.AliceBlue;
            this.titlu.Name = "titlu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ShipPic
            // 
            this.ShipPic.BackColor = System.Drawing.Color.Transparent;
            this.ShipPic.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ShipPic, "ShipPic");
            this.ShipPic.Name = "ShipPic";
            this.ShipPic.TabStop = false;
            this.ShipPic.Click += new System.EventHandler(this.ShipPic_Click);
            // 
            // MiniGames
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.battleShips);
            this.Controls.Add(this.mineSweeper);
            this.Controls.Add(this.ShipPic);
            this.Controls.Add(this.ticTacToe);
            this.Controls.Add(this.MinePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MiniGames";
            ((System.ComponentModel.ISupportInitialize)(this.MinePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MinePic;
        private System.Windows.Forms.PictureBox ticTacToe;
        private System.Windows.Forms.Label mineSweeper;
        private System.Windows.Forms.Label battleShips;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ShipPic;
    }
}
