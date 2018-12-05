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
            this.usor = new System.Windows.Forms.CheckBox();
            this.avansat = new System.Windows.Forms.CheckBox();
            this.mediu = new System.Windows.Forms.CheckBox();
            this.nivel = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.nivelDificulatate = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.backButton.Size = new System.Drawing.Size(51, 45);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 4;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // usor
            // 
            this.usor.AutoSize = true;
            this.usor.BackColor = System.Drawing.Color.Transparent;
            this.usor.ForeColor = System.Drawing.Color.MediumBlue;
            this.usor.Location = new System.Drawing.Point(61, 115);
            this.usor.Name = "usor";
            this.usor.Size = new System.Drawing.Size(48, 17);
            this.usor.TabIndex = 0;
            this.usor.Text = "Usor";
            this.usor.UseVisualStyleBackColor = false;
            this.usor.CheckedChanged += new System.EventHandler(this.Usor_CheckedChanged);
            // 
            // avansat
            // 
            this.avansat.AutoSize = true;
            this.avansat.BackColor = System.Drawing.Color.Transparent;
            this.avansat.ForeColor = System.Drawing.Color.MediumBlue;
            this.avansat.Location = new System.Drawing.Point(61, 161);
            this.avansat.Name = "avansat";
            this.avansat.Size = new System.Drawing.Size(65, 17);
            this.avansat.TabIndex = 1;
            this.avansat.Text = "Avansat";
            this.avansat.UseVisualStyleBackColor = true;
            // 
            // mediu
            // 
            this.mediu.AutoSize = true;
            this.mediu.BackColor = System.Drawing.Color.Transparent;
            this.mediu.ForeColor = System.Drawing.Color.MediumBlue;
            this.mediu.Location = new System.Drawing.Point(61, 138);
            this.mediu.Name = "mediu";
            this.mediu.Size = new System.Drawing.Size(55, 17);
            this.mediu.TabIndex = 2;
            this.mediu.Text = "Mediu";
            this.mediu.UseVisualStyleBackColor = true;
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.Transparent;
            this.nivel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.nivel.ForeColor = System.Drawing.Color.MediumBlue;
            this.nivel.Location = new System.Drawing.Point(69, 181);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(169, 23);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel de dificultate";
            this.nivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nivel.Click += new System.EventHandler(this.Nivel_Click);
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.Color.Transparent;
            this.Color.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.Color.ForeColor = System.Drawing.Color.MediumBlue;
            this.Color.Location = new System.Drawing.Point(78, 70);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(148, 23);
            this.Color.TabIndex = 5;
            this.Color.Text = "Alegeti culoarea";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // startButton
            // 
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startButton.Location = new System.Drawing.Point(232, 360);
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
            this.nivelDificulatate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivelDificulatate.LargeChange = 1;
            this.nivelDificulatate.Location = new System.Drawing.Point(82, 226);
            this.nivelDificulatate.Maximum = 3;
            this.nivelDificulatate.Minimum = 1;
            this.nivelDificulatate.Name = "nivelDificulatate";
            this.nivelDificulatate.Size = new System.Drawing.Size(172, 58);
            this.nivelDificulatate.TabIndex = 8;
            this.nivelDificulatate.Tag = "";
            this.nivelDificulatate.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Tag = "Usor";
            this.label1.Text = "Usor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Tag = "Mediu";
            this.label2.Text = "Mediu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Tag = "Greu";
            this.label3.Text = "Greu";
            // 
            // MinesweeperSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nivelDificulatate);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.avansat);
            this.Controls.Add(this.mediu);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usor);
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
        private System.Windows.Forms.CheckBox usor;
        private System.Windows.Forms.CheckBox avansat;
        private System.Windows.Forms.CheckBox mediu;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TrackBar nivelDificulatate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}