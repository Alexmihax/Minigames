﻿namespace Minigames1
{
    partial class MinesweeperSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperSettings));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.nivel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nivelDificulatate = new System.Windows.Forms.TrackBar();
            this.usor = new System.Windows.Forms.Label();
            this.mediu = new System.Windows.Forms.Label();
            this.greu = new System.Windows.Forms.Label();
            this.latimeN = new System.Windows.Forms.Label();
            this.lungimeN = new System.Windows.Forms.Label();
            this.latime = new System.Windows.Forms.TextBox();
            this.mine = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.mineN = new System.Windows.Forms.Label();
            this.lungime = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelDificulatate)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(9, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(57, 45);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 4;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.Transparent;
            this.nivel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.nivel.ForeColor = System.Drawing.Color.AliceBlue;
            this.nivel.Location = new System.Drawing.Point(394, 90);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(169, 23);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel de dificultate";
            this.nivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startButton.Location = new System.Drawing.Point(87, 134);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 27);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // nivelDificulatate
            // 
            this.nivelDificulatate.AutoSize = false;
            this.nivelDificulatate.BackColor = System.Drawing.Color.Gray;
            this.nivelDificulatate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivelDificulatate.LargeChange = 1;
            this.nivelDificulatate.Location = new System.Drawing.Point(391, 134);
            this.nivelDificulatate.Maximum = 3;
            this.nivelDificulatate.Minimum = 1;
            this.nivelDificulatate.Name = "nivelDificulatate";
            this.nivelDificulatate.Size = new System.Drawing.Size(172, 55);
            this.nivelDificulatate.TabIndex = 8;
            this.nivelDificulatate.Tag = "";
            this.nivelDificulatate.Value = 1;
            // 
            // usor
            // 
            this.usor.AutoSize = true;
            this.usor.BackColor = System.Drawing.Color.Gray;
            this.usor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usor.ForeColor = System.Drawing.Color.Lime;
            this.usor.Location = new System.Drawing.Point(391, 161);
            this.usor.Name = "usor";
            this.usor.Size = new System.Drawing.Size(33, 15);
            this.usor.TabIndex = 9;
            this.usor.Tag = "Ușor";
            this.usor.Text = "Ușor";
            // 
            // mediu
            // 
            this.mediu.AutoSize = true;
            this.mediu.BackColor = System.Drawing.Color.Gray;
            this.mediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mediu.ForeColor = System.Drawing.Color.Yellow;
            this.mediu.Location = new System.Drawing.Point(452, 161);
            this.mediu.Name = "mediu";
            this.mediu.Size = new System.Drawing.Size(42, 15);
            this.mediu.TabIndex = 10;
            this.mediu.Tag = "Mediu";
            this.mediu.Text = "Mediu";
            // 
            // greu
            // 
            this.greu.AutoSize = true;
            this.greu.BackColor = System.Drawing.Color.Gray;
            this.greu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greu.ForeColor = System.Drawing.Color.Red;
            this.greu.Location = new System.Drawing.Point(529, 161);
            this.greu.Name = "greu";
            this.greu.Size = new System.Drawing.Size(34, 15);
            this.greu.TabIndex = 11;
            this.greu.Tag = "Greu";
            this.greu.Text = "Greu";
            // 
            // latimeN
            // 
            this.latimeN.AutoSize = true;
            this.latimeN.BackColor = System.Drawing.Color.Transparent;
            this.latimeN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.latimeN.ForeColor = System.Drawing.Color.AliceBlue;
            this.latimeN.Location = new System.Drawing.Point(354, 281);
            this.latimeN.Name = "latimeN";
            this.latimeN.Size = new System.Drawing.Size(70, 23);
            this.latimeN.TabIndex = 14;
            this.latimeN.Text = "Latime";
            this.latimeN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lungimeN
            // 
            this.lungimeN.AutoSize = true;
            this.lungimeN.BackColor = System.Drawing.Color.Transparent;
            this.lungimeN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lungimeN.ForeColor = System.Drawing.Color.AliceBlue;
            this.lungimeN.Location = new System.Drawing.Point(435, 281);
            this.lungimeN.Name = "lungimeN";
            this.lungimeN.Size = new System.Drawing.Size(79, 23);
            this.lungimeN.TabIndex = 15;
            this.lungimeN.Text = "Inaltime";
            this.lungimeN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // latime
            // 
            this.latime.Location = new System.Drawing.Point(358, 307);
            this.latime.MaxLength = 3;
            this.latime.Name = "latime";
            this.latime.Size = new System.Drawing.Size(66, 20);
            this.latime.TabIndex = 16;
            this.latime.Text = "Alegeti!";
            this.latime.Click += new System.EventHandler(this.Latime_Enter);
            this.latime.TextChanged += new System.EventHandler(this.Latime_Enter);
            // 
            // mine
            // 
            this.mine.Location = new System.Drawing.Point(536, 307);
            this.mine.MaxLength = 3;
            this.mine.Name = "mine";
            this.mine.Size = new System.Drawing.Size(66, 20);
            this.mine.TabIndex = 17;
            this.mine.Text = "Alegeti!";
            this.mine.Click += new System.EventHandler(this.Mine_Enter);
            this.mine.TextChanged += new System.EventHandler(this.Mine_Enter);
            // 
            // quitButton
            // 
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quitButton.Location = new System.Drawing.Point(87, 249);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(142, 27);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Iesire";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mineN
            // 
            this.mineN.AutoSize = true;
            this.mineN.BackColor = System.Drawing.Color.Transparent;
            this.mineN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.mineN.ForeColor = System.Drawing.Color.AliceBlue;
            this.mineN.Location = new System.Drawing.Point(519, 281);
            this.mineN.Name = "mineN";
            this.mineN.Size = new System.Drawing.Size(105, 23);
            this.mineN.TabIndex = 18;
            this.mineN.Text = "Nr. de mine";
            this.mineN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lungime
            // 
            this.lungime.Location = new System.Drawing.Point(445, 307);
            this.lungime.MaxLength = 3;
            this.lungime.Name = "lungime";
            this.lungime.Size = new System.Drawing.Size(66, 20);
            this.lungime.TabIndex = 19;
            this.lungime.Text = "Alegeti";
            this.lungime.Click += new System.EventHandler(this.Lungime_Enter);
            this.lungime.TextChanged += new System.EventHandler(this.Lungime_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(431, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Customizare";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(87, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cum se joaca?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinesweeperSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lungime);
            this.Controls.Add(this.mineN);
            this.Controls.Add(this.mine);
            this.Controls.Add(this.latime);
            this.Controls.Add(this.lungimeN);
            this.Controls.Add(this.latimeN);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.greu);
            this.Controls.Add(this.usor);
            this.Controls.Add(this.mediu);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.nivelDificulatate);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MinesweeperSettings";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelDificulatate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TrackBar nivelDificulatate;
        private System.Windows.Forms.Label usor;
        private System.Windows.Forms.Label mediu;
        private System.Windows.Forms.Label greu;
        private System.Windows.Forms.Label latimeN;
        private System.Windows.Forms.Label lungimeN;
        private System.Windows.Forms.TextBox latime;
        private System.Windows.Forms.TextBox mine;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label mineN;
        private System.Windows.Forms.TextBox lungime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}