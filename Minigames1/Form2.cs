using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames1
{
    public partial class MinesweeperSettings : Form
    {
        public MinesweeperSettings()
        {
            InitializeComponent();
        }
        private void Usor_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Avansat_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Mediu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MiniGames();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void DifficultyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nivel_Click(object sender, EventArgs e)
        {

        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {

        }
        private void Color_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Minesweeper();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void nivelDificulatate_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
