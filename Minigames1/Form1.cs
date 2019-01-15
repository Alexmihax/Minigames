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
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void MinePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MinesweeperSettings();
            form2.Closed += (s, args) => this.Close();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }
    }
}
