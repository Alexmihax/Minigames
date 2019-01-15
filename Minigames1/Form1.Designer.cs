using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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
            this.mineSweeper = new System.Windows.Forms.Label();
            this.battleShips = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShipPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinePic)).BeginInit();
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
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Name = "label5";
            // 
            // MiniGames
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.battleShips);
            this.Controls.Add(this.mineSweeper);
            this.Controls.Add(this.ShipPic);
            this.Controls.Add(this.MinePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MiniGames";
            ((System.ComponentModel.ISupportInitialize)(this.MinePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MinePic;
        private System.Windows.Forms.Label mineSweeper;
        private System.Windows.Forms.Label battleShips;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ShipPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Label label5;
    }
}
