using System.Drawing;

namespace Minigames1
{
    partial class Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.flagsCounter = new System.Windows.Forms.Label();
            this.timeCounter = new System.Windows.Forms.Label();
            this.bombs = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flagsCounter
            // 
            this.flagsCounter.AutoSize = true;
            this.flagsCounter.BackColor = System.Drawing.Color.Black;
            this.flagsCounter.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.flagsCounter.ForeColor = System.Drawing.Color.Red;
            this.flagsCounter.Location = new System.Drawing.Point(59, 15);
            this.flagsCounter.Name = "flagsCounter";
            this.flagsCounter.Size = new System.Drawing.Size(56, 31);
            this.flagsCounter.TabIndex = 7;
            this.flagsCounter.Text = "000";
            // 
            // timeCounter
            // 
            this.timeCounter.AutoSize = true;
            this.timeCounter.BackColor = System.Drawing.Color.Black;
            this.timeCounter.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.timeCounter.ForeColor = System.Drawing.Color.Red;
            this.timeCounter.Location = new System.Drawing.Point(313, 15);
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(56, 31);
            this.timeCounter.TabIndex = 8;
            this.timeCounter.Text = "000";
            // 
            // bombs
            // 
            this.bombs.AutoSize = true;
            this.bombs.BackColor = System.Drawing.Color.Black;
            this.bombs.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.bombs.ForeColor = System.Drawing.Color.Red;
            this.bombs.Location = new System.Drawing.Point(112, 15);
            this.bombs.Name = "bombs";
            this.bombs.Size = new System.Drawing.Size(77, 31);
            this.bombs.TabIndex = 9;
            this.bombs.Text = "Flags";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Black;
            this.time.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(245, 15);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(74, 31);
            this.time.TabIndex = 10;
            this.time.Text = "Time";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::Minigames1.Properties.Resources.back_icon;
            this.backButton.Location = new System.Drawing.Point(2, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(51, 38);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 11;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Minigames1.Properties.Resources.startface1;
            this.button1.Location = new System.Drawing.Point(195, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minigames1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.bombs);
            this.Controls.Add(this.timeCounter);
            this.Controls.Add(this.flagsCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label flagsCounter;
        private System.Windows.Forms.Label timeCounter;
        private System.Windows.Forms.Label bombs;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Button button1;
    }
}