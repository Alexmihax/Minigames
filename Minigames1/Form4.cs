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
        //Declaration of Variables

        Button[,] btn = new Button[50, 50];
        int[,] btn_state = new int[50, 50];
        int[,] saved_btn_state = new int[50, 50];

        Point coord;

        bool firstplay = true;
        bool gameover = false;

        //Directional Arrays on OX and OY
        int[] dx = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };

        //Time Counter
        Timer timer;

        //Game Variables
        int mines;
        int flag_value = 10;
        int flags;

        //Button Aspect
        int button_size = 20;
        int distance_between = 20;

        //Table Aspect
        int start_x, start_y;
        int width, height;


        public Minesweeper()
        {
            switch (MinesweeperSettings.custom)
            {
                case true:
                    {
                        width = MinesweeperSettings.w;
                        height = MinesweeperSettings.h;
                        mines = MinesweeperSettings.mine_nr;
                    }
                    break;
                case false:
                    {
                        switch (MinesweeperSettings.niv)
                        {
                            case 1:
                                {
                                    width = 9;
                                    height = 9;
                                    mines = 10;
                                }
                                break;

                            case 2:
                                {
                                    width = 16;
                                    height = 16;
                                    mines = 40;
                                }
                                break;

                            case 3:
                                {
                                    width = 16;
                                    height = 30;
                                    mines = 99;
                                }
                                break;
                        }
                    }
                    break;
            }

            flags = mines;

            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MinesweeperSettings();
            form2.Closed += (s, args) => this.Close();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {

        }

        void Button_Image(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover && btn_state[x, y] == flag_value)
                btn_state[x, y] = saved_btn_state[x, y];

            if (gameover)
                timer.Enabled = false;

            switch (btn_state[x, y]) //Switches Button Image
            {
                case 0:
                    btn[x, y].BackgroundImage = Properties.Resources._0;
                    EmptySpace(x, y);
                    break;

                case 1:
                    btn[x, y].BackgroundImage = Properties.Resources._1;
                    break;

                case 2:
                    btn[x, y].BackgroundImage = Properties.Resources._2;
                    break;

                case 3:
                    btn[x, y].BackgroundImage = Properties.Resources._3;
                    break;

                case 4:
                    btn[x, y].BackgroundImage = Properties.Resources._4;
                    break;

                case 5:
                    btn[x, y].BackgroundImage = Properties.Resources._5;
                    break;

                case 6:
                    btn[x, y].BackgroundImage = Properties.Resources._6;
                    break;

                case 7:
                    btn[x, y].BackgroundImage = Properties.Resources._7;
                    break;

                case 8:
                    btn[x, y].BackgroundImage = Properties.Resources._8;
                    break;

                case -1:
                    btn[x, y].BackgroundImage = Properties.Resources.bomb;
                    if (gameover != true)
                        GameOver();
                    break;
            }

        }

        bool pointInBounds(int x, int y) //Check if a selected point respects the boundaries of the matrix
        {
            if (x < 1 || x > width || y < 1 || y > height)
                return false;
            return true;
        }

        void EmptySpace(int x, int y) //Compute all the empty neighbours of a cell/point
        {
            if (btn_state[x, y] == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int new_dx = x + dx[i];
                    int new_dy = y + dy[i];

                    if (pointInBounds(new_dx, new_dy))

                        Button_Image(new_dx, new_dy);
                }
            }
        }

        void Show_Map()
        {
            int i, j;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    if (btn[i, j].Enabled == true)
                        Button_Image(i, j);
                }

        }

        void Flag_Win_Check() //Checks if a player wins by placing all the flags on the correct positions(the bombs)
        {
            int i, j;
            bool win = true;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    if (btn_state[i, j] == -1)
                        win = false;
                }

            if (win) WinGame();

        }

        void GameOver()
        {
            gameover = true;
            Show_Map();
            MessageBox.Show("Game over !:(");
        }

        void WinGame()
        {
            gameover = true;
            Show_Map();
            MessageBox.Show("Congratulations, You WON!");
        }

        void Click_Win_Check() //Check if there are still empty cells (yes -> continue, no -> player wins)
        {
            int i, j;
            bool win = true;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    if (btn[i, j].Enabled == true && saved_btn_state[i, j] != -1)
                        win = false;
                }

            if (win) WinGame();
        }

        private void OnClick(object sender, EventArgs e)
        {

        }
        //Ramane sa vedem cum o facem (practic dupa ce dai click trebuie sa calculeze transformarile pe matrice) 
        //Si in plus sa vada daca exista castigator

        int Nearby_Mines(int x, int y) //Finds the number of adjacent mines of a cell/point
        {
            int i, count = 0;

            for (i = 0; i < 8; i++)
            {
                int new_dx = x + dx[i];
                int new_dy = y + dy[i];

                if (pointInBounds(new_dx, new_dy) && btn_state[new_dx, new_dy] == -1)
                    count++;
            }

            return count;
        }

        void Set_Map_Numbers(int x, int y)
        {
            int i, j;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    if (btn_state[i, j] != -1)
                    {
                        btn_state[i, j] = Nearby_Mines(i, j);

                        saved_btn_state[i, j] = Nearby_Mines(i, j);
                    }
                }
        }

        private void Flag_Cell(object sender, MouseEventArgs e) // Function to add Flags
        {
            if (e.Button == MouseButtons.Right)
            {
                coord = ((Button)sender).Location;
                int x = (coord.X - start_x) / button_size;
                int y = (coord.Y - start_y) / button_size;

                if (btn_state[x, y] != 10 && flags > 0)
                {
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = Minigames1.Properties.Resources.flagged;

                    btn_state[x, y] = flag_value;

                    flags--;
                    Flag_Win_Check();
                }

                else if (btn_state[x, y] == flag_value)
                {
                    btn_state[x, y] = saved_btn_state[x, y];
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = null;

                    flags++;
                }

                flagsCounter.Text = flags.ToString();
            }
        }

        void Generate_Buttons(int x, int y)
        {
            int i, j;

            for (i = 1; i <= x; i++)
                for (j = 1; j <= y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(i * button_size + start_x, j * button_size + start_y, distance_between, distance_between);
                    btn[i, j].Click += new EventHandler(OnClick);
                    btn[i, j].MouseUp += new MouseEventHandler(Flag_Cell);
                    btn_state[i, j] = 0;
                    saved_btn_state[i, j] = 0;
                    Controls.Add(btn[i, j]);

                }
        }

        void Generate_Map(int x, int y, int m)
        {

        }

        public void OnTimeEvent(object source, EventArgs e)
        {
            int seconds = int.Parse(timeCounter.Text);
            seconds++;
            timeCounter.Text = seconds.ToString().PadLeft(3, '0');
        }
        public void StartTimer() // set to start when pressing the Status Button
        {
            timer = new Timer
            {
                Interval = 1000
            };              
            timer.Start();
            timer.Tick += new System.EventHandler(OnTimeEvent);
        }
        void StartGame()
        {
            flags = mines;
            flagsCounter.Text = flags.ToString().PadLeft(3, '0');
            gameover = false;

            timeCounter.Text = "000";
            StartTimer();

            if (firstplay)
                Generate_Buttons(width, height);

            Generate_Map(width, height, mines);
            Set_Map_Numbers(width, height);
        }

        void ResetGame()
        {
            int i, j;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    btn[i, j].Enabled = true;
                    btn_state[i, j] = 0;
                    saved_btn_state[i, j] = 0;

                    btn[i, j].BackgroundImage = null;
                    btn[i, j].Text = "";
                }
            timer.Stop();
        }

        void Matrix_Margins(int x, int y)
        {
            start_x = (width * distance_between) / 2;
            start_y = (height * distance_between) / 2;
        }

        private void Button1_Click(object sender, EventArgs e) //A.K.A Reset Game Button
        {
            Matrix_Margins(width, height);

            if (!firstplay)
            {
                ResetGame();
                StartGame();
            }

            if (firstplay)
            {
                StartGame();
                firstplay = false;
            }           
        
        }
    }
}