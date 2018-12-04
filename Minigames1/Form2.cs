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
    public partial class Minesweeper : Form
    {
        public Minesweeper()
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
    }
}
