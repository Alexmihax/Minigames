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
    public partial class MiniGames : Form
    {
        public MiniGames()
        {
            InitializeComponent();
        }
        private void MinePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Minesweeper();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void ShipPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
