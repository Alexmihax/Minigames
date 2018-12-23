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

        int startGame = true;
        int gameover = false;

        //Directional Arrays on OX and OY
        int[] dx = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };

        //Time Counter
        int seconds = 0;
        int minutes = 0;

        //Game Variables
        int mines;
        int flag_value = 10;
        int flag;
        int game_mode; //easy, medium, hard
        int gameScore = 0;

        //Button Aspect
        int button_size = 20;
        int distance_between = 20;

        //Table Aspect
        int start_x, start_y;
        int width, height;

        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {

        }

        void Button_Image(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover && btn_state[x, y] = flag_value)
                btn_state[x, y] = saved_btn_state[x, y];

            if (gameover)
                timer.Stop();

            switch(btn_state[x,y]) //Switches Button Image
            {
                case 0:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._0;
                    EmptySpace(x, y);
                    break;

                case 1:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._1;
                    break;

                case 2:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._2;
                    break;

                case 3:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._3;
                    break;

                case 4:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._4;
                    break;

                case 5:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._5;
                    break;

                case 6:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._6;
                    break;

                case 7:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._8;
                    break;

                case 8:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources._8;
                    break;

                case -1:
                    btn_state[x, y].BackgroundImage = Minesweeper.Properties.Resources.bomb;
                    if (gameover != true)
                        GameOver();
                    break;
            }

        }

        int pointInBounds(int x, int y) //Check if a selected point respects the boundaries of the matrix
        {
            if (x < 1 || x > width || y < 1 || y > height)
                return false;
            return true;
        }

        void EmptySapce(int x, int y) //Compute all the empty neighbours of a cell/point
        {
            if(btn_state[x,y] == 0)
            {
                for(i = 0; i < 8; i++)
                {
                    int new_dx = x + dx[i];
                    int new_dy = y + dy[i];

                    if(pointInBounds(new_dx, new_dy))
                    {
                        gameScore++;
                        score.Text = "Score: " + gameScore;
                        Button_Image(new_dx, new_dy);
                    }
                }
            }
        }

        void Show_Map()
        {
            int i, j;

            for(i = 1; i <= width; i++)
               for(j = 1; j <= height; j++)
                {
                    if (btn[i, j].Enabled == true)
                        Button_Image(i, j);
                }
                
        }

        void GameOver()
        {
            gameover = true;
            Show_Map();
            MessageBox.Show("Game over !:(");
        }

        void Flag_Win_Check() //Checks if a player wins by placing all the flags on the correct positions(the bombs)
        {
            int i, j;
            bool win = true;

            for (i = 1; i <= width; i++)
                for (j = 1; j <= height; j++)
                {
                    if (btn[i, j].Enabled == -1)
                        win = false;
                }

            if (win) WinGame();

        }

        void WinGame()
        {
            gameover = true;
            Show_Map();
            gameScore = 0;
            MessageBox.Show("Congratulations, You WON!");
        }

        void Click_Win_Check() //Ceck if there are still empty cells (yes -> continue, no -> player wins)
        {
            int i, j;
            bool win = true;

            for(i = 1; i <= width; i++)
               for(j = 1; j <= height; j++)
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

            for(i = 0; i < 8; i++)
            {
                int new_dx = x + dx[i];
                int new_dy = y + dy[i];

                if (pointInBounds(new_dx, new_dy) && btn_state == -1)
                    count++;
            }

            return count;
        }

        void Set_Map_Numbers(int x, int y)
        {
            int i, j;

            for(i = 1; i <= width; i++)
               for(j = 1; j <= height; j++)
                {
                    if (btn_state[i, j] != -1)
                    {
                        btn_state[i, j] = Nearby_Mines(i, j);

                        saved_btn_state[i, j] = Nearby_Mines(i, j); 
                    }
                }
        }

        private void Flag_Cell(onject sender, MouseEventArgs e) // Function to add Flags
        {

        }

        void Generate_Buttons(int x, int y)
        {

        }

        void Generate_Map(int x, int y, int m)
        {

        }

        void StartGame()
        {

        }

        void ResetGame()
        {

        }

        void Warning(int ok)
        {
            switch(ok)
            {
                case 1:
                    MessageBox.Show("Empty Fields !");
                    break;

                case 2:
                    MessageBox.Show("Input is not Valid!");
                    break;
            }
        }

        bool Input_has_Letters(string s)
        {
            int i, len = s.legth();

            for (i = 0; i < len; i++)

                if (!Char.IsDigit(s, i)) return true;
            return false;
        }

        bool Check_Input() //Check if the input is not empty and contains numbers only
        {

        }

        void SetDimensions()
        {

        }

        void Matrix_Margins(int x, int y)
        {

        }

        private void Play_Button(object sender, EventArgs e) //If the inpus is correct (first game -> create everything) / (! first game -> reset everything)
        {

        }

        private void Start_Timer(object sender, EventArgs e)
        {

        }
       

     
    }
}
