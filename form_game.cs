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
        GameData gameData = new GameData();
        DataTransferObject _dto;

        public form_game(DataTransferObject dto)
        {
            InitializeComponent();
            _dto = dto;
        }

        public void loadFields(object sender, EventArgs e)
        {
            gameData.loadFields(sender, e);
        }

        private void loadMenu(object sender, FormClosedEventArgs e)
        {
            this.Close();
            form_menu menu = new form_menu();
            menu.Show();
            
        }
        
        public int getFieldNum(object sender)
        {
            char LastSign = (sender as PictureBox).Name[(sender as PictureBox).Name.Length - 1];
            return LastSign - '0';
        }
        private void mouseOnField(object sender, EventArgs e)
        {
            if (!gameData.Fields[getFieldNum(sender)].IsTaken)
            {
                (sender as PictureBox).Image = Properties.Resources.field_hover;
            }
        }

        private void mouseOutField(object sender, EventArgs e)
        {
            if (!gameData.Fields[getFieldNum(sender)].IsTaken)
            {
                (sender as PictureBox).Image = Properties.Resources.field;
            }
        }

        private void clickField(object sender, MouseEventArgs e)
        {
            bool IfMoved = false;
            if (gameData.CurrentPlayer)
            {
                if (!gameData.Fields[getFieldNum(sender)].IsTaken)
                {
                    (sender as PictureBox).Image = Properties.Resources.field_x;
                    gameData.Fields[getFieldNum(sender)].IsTaken = true;
                    gameData.Fields[getFieldNum(sender)].Player = gameData.CurrentPlayer;
                    gameData.CurrentPlayer = !gameData.CurrentPlayer;
                    gameData.NumMoves++;
                    IfMoved = true;
                }
                
            }
            else
            {
                if (!gameData.Fields[getFieldNum(sender)].IsTaken)
                {
                    (sender as PictureBox).Image = Properties.Resources.field_o;
                    gameData.Fields[getFieldNum(sender)].IsTaken = true;
                    gameData.Fields[getFieldNum(sender)].Player = gameData.CurrentPlayer;
                    gameData.CurrentPlayer = !gameData.CurrentPlayer;
                    gameData.NumMoves++;
                    IfMoved = true;
                }
            }
            if (IfMoved)
            {
                int status = gameData.getGameStatus();
                // game in progress
                if (status == 0)
                {
                    if (gameData.CurrentPlayer)
                        game_status.Text = "Player on move: X";
                    else
                        game_status.Text = "Player on move: O";
                }
                // 'x' player wins
                else if (status == 1)
                {
                    game_status.Text = "Player X won!";
                }
                else if (status == 2)
                // 'o' player wins
                {
                    game_status.Text = "Player O won!";
                }
                else if (status == 3)
                // draw
                {
                    game_status.Text = "Draw.";
                }

            }
        }
    }
}
