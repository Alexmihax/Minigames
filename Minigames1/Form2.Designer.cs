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
            this.backButton = new System.Windows.Forms.PictureBox();
            this.usor = new System.Windows.Forms.CheckBox();
            this.avansat = new System.Windows.Forms.CheckBox();
            this.mediu = new System.Windows.Forms.CheckBox();
            this.nivel = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.nivel.Location = new System.Drawing.Point(74, 80);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(169, 23);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel de dificultate";
            this.nivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nivel.Click += new System.EventHandler(this.Nivel_Click);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.BackColor = System.Drawing.Color.Transparent;
            this.Color.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.Color.ForeColor = System.Drawing.Color.MediumBlue;
            this.Color.Location = new System.Drawing.Point(78, 185);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(148, 23);
            this.Color.TabIndex = 5;
            this.Color.Text = "Alegeti culoarea";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(219, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(91, 226);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 8;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.avansat);
            this.Controls.Add(this.mediu);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Minesweeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}