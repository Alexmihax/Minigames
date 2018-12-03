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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.nivel = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.difficultyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Usor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.Controls.Add(this.nivel);
            this.difficultyPanel.Controls.Add(this.checkBox3);
            this.difficultyPanel.Controls.Add(this.checkBox2);
            this.difficultyPanel.Controls.Add(this.checkBox1);
            this.difficultyPanel.Location = new System.Drawing.Point(184, 137);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(203, 122);
            this.difficultyPanel.TabIndex = 1;
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.Transparent;
            this.nivel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.nivel.Location = new System.Drawing.Point(3, 14);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(169, 23);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel de dificultate";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mediu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Avansat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 71);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 4;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.difficultyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.difficultyPanel.ResumeLayout(false);
            this.difficultyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel difficultyPanel;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label nivel;
    }
}