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

        private void Minesweeper_Load(object sender, EventArgs e)
        {

        }
        private void StatusButton_Click(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MinesweeperSettings();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
