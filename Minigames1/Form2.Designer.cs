namespace Minigames1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.how = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
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
            this.nivel.Click += new System.EventHandler(this.Nivel_Click);
            // 
            // startButton
            // 
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startButton.Location = new System.Drawing.Point(87, 90);
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
            this.nivelDificulatate.Size = new System.Drawing.Size(172, 58);
            this.nivelDificulatate.TabIndex = 8;
            this.nivelDificulatate.Tag = "";
            this.nivelDificulatate.Value = 1;
            this.nivelDificulatate.Scroll += new System.EventHandler(this.nivelDificulatate_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(395, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Tag = "Usor";
            this.label1.Text = "Usor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(459, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Tag = "Mediu";
            this.label2.Text = "Mediu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(533, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Tag = "Greu";
            this.label3.Text = "Greu";
            // 
            // how
            // 
            this.how.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.how.Location = new System.Drawing.Point(87, 134);
            this.how.Name = "how";
            this.how.Size = new System.Drawing.Size(142, 27);
            this.how.TabIndex = 12;
            this.how.Text = "Cum se joaca?";
            this.how.UseVisualStyleBackColor = true;
            this.how.Click += new System.EventHandler(this.button1_Click);
            // 
            // quitButton
            // 
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quitButton.Location = new System.Drawing.Point(87, 181);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(142, 27);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // MinesweeperSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.how);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.nivelDificulatate);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinesweeperSettings";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Minesweeper_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button how;
        private System.Windows.Forms.Button quitButton;
    }
}