using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTGame
{

    public partial class form_game : Form
    {
        Field[] fields = new Field[9];
        bool CurrentPlayer = true; // true - X, false - O
        int NumMoves = 0;

        public form_game()
        {
            InitializeComponent();
        }
        private int getGameStatus()
        {
            // Possible outcomes
            // 0 - in progress
            // 1 - X player wins,
            // 2 - O player wins,
            // 3 - draw

            // Checking win status
            for (int i = 0; i < 3; i++)
            {
                int idx = 3 * i;

                //row
                if ((fields[idx].IsTaken == true) && (fields[idx+1].IsTaken == true) && (fields[idx + 2].IsTaken == true))
                {
                    if ((fields[idx].Player == fields[idx+1].Player) && (fields[idx+1].Player == fields[idx+2].Player)) 
                    {
                        if (fields[idx].Player) return 1;
                        else return 2;
                    }
                }
                //column
                if ((fields[i].IsTaken == true) && (fields[i + 3].IsTaken == true) && (fields[i + 6].IsTaken == true))
                {
                    if ((fields[i].Player == fields[i + 3].Player) && (fields[i + 3].Player == fields[i + 6].Player))
                    {
                        if (fields[i].Player) return 1;
                        else return 2;
                    }
                }
            }
            //diagonal
            if ((fields[0].IsTaken == true) && (fields[4].IsTaken == true) && (fields[8].IsTaken == true))
            {
                if ((fields[0].Player == fields[4].Player) && (fields[4].Player == fields[8].Player))
                {
                    if (fields[0].Player) return 1;
                    else return 2;
                }
            }
            if ((fields[2].IsTaken == true) && (fields[4].IsTaken == true) && (fields[6].IsTaken == true))
            {
                if ((fields[2].Player == fields[4].Player) && (fields[4].Player == fields[6].Player))
                {
                    if (fields[2].Player) return 1;
                    else return 2;
                }
            }

            // Checking draw status
            if (NumMoves == 9)
            {
                return 3;
            }
            
            // Game in progress
            return 0;

        }
        private void loadMenu(object sender, FormClosedEventArgs e)
        {
            this.Close();
            form_menu menu = new form_menu();
            menu.Show();
        }
        private void loadFields(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                fields[i] = new Field($"field_{i}", i, false);
            }
        }
        public int getFieldNum(object sender)
        {
            char LastSign = (sender as PictureBox).Name[(sender as PictureBox).Name.Length - 1];
            return LastSign - '0';
        }
        private void mouseOnField(object sender, EventArgs e)
        {
            if (!fields[getFieldNum(sender)].IsTaken)
            {
                (sender as PictureBox).Image = Properties.Resources.field_hover;
            }
        }

        private void mouseOutField(object sender, EventArgs e)
        {
            if (!fields[getFieldNum(sender)].IsTaken)
            {
                (sender as PictureBox).Image = Properties.Resources.field;
            }
        }

        private void clickField(object sender, MouseEventArgs e)
        {
            bool IfMoved = false;
            if (CurrentPlayer)
            {
                if (!fields[getFieldNum(sender)].IsTaken)
                {
                    (sender as PictureBox).Image = Properties.Resources.field_x;
                    fields[getFieldNum(sender)].IsTaken = true;
                    fields[getFieldNum(sender)].Player = CurrentPlayer;
                    CurrentPlayer = !CurrentPlayer;
                    NumMoves++;
                    IfMoved = true;
                }
                
            }
            else
            {
                if (!fields[getFieldNum(sender)].IsTaken)
                {
                    (sender as PictureBox).Image = Properties.Resources.field_o;
                    fields[getFieldNum(sender)].IsTaken = true;
                    fields[getFieldNum(sender)].Player = CurrentPlayer;
                    CurrentPlayer = !CurrentPlayer;
                    NumMoves++;
                    IfMoved = true;
                }
            }
            if (IfMoved)
            {
                int status = getGameStatus();
                if (status == 0)
                {
                    if (CurrentPlayer)
                        game_status.Text = "Player on move: X";
                    else
                        game_status.Text = "Player on move: O";
                }
                else if (status == 1)
                {
                    game_status.Text = "Player X won!";
                }
                else if (status == 2)
                {
                    game_status.Text = "Player O won!";
                }
                else if (status == 3)
                {
                    game_status.Text = "Draw.";
                }

            }
        }
    }
}
