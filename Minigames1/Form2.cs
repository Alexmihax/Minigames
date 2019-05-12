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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MiniGames();
            form1.Closed += (s, args) => this.Close();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }

        public static int niv, w, h, mine_nr;
        public static bool custom;
        
        private void Start_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && lungime.Text != null && lungime.Text!="Choose!" && latime.Text != null && latime.Text != "Choose!" && lungime.Text != null && mine.Text != "Choose!" && lungime.Text != null && mine.Text != "Choose!")
            {
                custom = true;
                w = int.Parse(lungime.Text);
                h = int.Parse(latime.Text);
                mine_nr = int.Parse(mine.Text);
            }
            else
            {
                custom = false;
                niv = nivelDificulatate.Value;
            }
            this.Hide();
            var form4 = new Minesweeper();
            form4.Closed += (s, args) => this.Close();
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Show();
        }


        private void Quit_Click(object sender, EventArgs e) => this.Close();

        private bool flag;
        private int val;

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("https://www.instructables.com/id/How-to-beat-Minesweeper/");
        }        

        private void Latime_Enter(object sender, EventArgs e)
        {
            
            if (flag == false)
            {
                flag = true;
                try
                {
                    val = System.Convert.ToInt32(latime.Text);
                }
                catch
                {
                    latime.Clear();
                }
                flag = false;

            }
        }

        private void Lungime_Enter(object sender, EventArgs e)

        {
            
            if (flag == false)
            {
                flag = true;
                try
                {
                    val = System.Convert.ToInt32(lungime.Text);
                }
                catch
                {
                    lungime.Clear();
                }

                flag = false;
            }
        }
        private void Mine_Enter(object sender, EventArgs e)

        {
           
            if (flag == false)
            {
                flag = true;
                try
                {
                    val = System.Convert.ToInt32(mine.Text);
                }
                catch
                {
                    mine.Clear();
                }
                flag = false;

            }

        }
    }
}