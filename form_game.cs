using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TTTGame
{

    public partial class form_game : Form
    {
        GameData gameData = new GameData();
        DataTransferObject _dto;
        bool Xplayer; // true - first player is 'X', false - second player is 'X'
        int round = 0;
        bool IfEndGame = false;
        bool againstBot = false;
        bool botOnMove = false;
        Bot bot;

        public form_game(DataTransferObject dto)
        {
            InitializeComponent();
            _dto = dto;
        }

        private void loadMenu(object sender, FormClosedEventArgs e)
        {
            this.Close();
            form_menu menu = new form_menu();
            menu.Show();
            
        }
        private void startGame()
        {
            gameData.loadFields();
            gameData.NumMoves = 0;
            gameData.CurrentPlayer = true;

            if (round == 0)
            {
                Random random = new Random();
                Xplayer = random.Next(2) == 0;
                botOnMove = !Xplayer;
            }
            else
            {
                Xplayer = !Xplayer;
                botOnMove = !Xplayer;
            }

            if (botOnMove)
            {
                panel_board.Enabled = false;
            }

            for (int i = 0; i < 9; i++)
            {
                Control[] fld = this.Controls.Find($"field_{i}", true);
                (fld[0] as PictureBox).Image = Properties.Resources.field;
                
            }
                

            round++;
            label_result.Text = $"{gameData.ResultPlayer1}:{gameData.ResultPlayer2}";
            label_player1_sign.Text = (Xplayer) ? "X" : "O";
            label_player2_sign.Text = (Xplayer) ? "O" : "X";
            label_bestof.Text = $"Best-of: {_dto.Bestof}";
            label_round.Text = $"Round: {round}";

            panel_board.Enabled = true ;

        }

        private void loadGameForm(object sender, EventArgs e)
        {
            gameData.Player1 = _dto.PlayerNickname;
            gameData.Player2 = _dto.OpponentNickname;
            gameData.ResultPlayer1 = gameData.ResultPlayer2 = 0;
            round = 0;
            startGame();

            label_player1.Text = _dto.PlayerNickname;
            label_player2.Text = _dto.OpponentNickname;

            if (_dto.ChosenOpponent != "player") 
            { 
                if (_dto.ChosenOpponent == "easy_bot")
                {
                    bot = new EasyBot();
                }
                else if (_dto.ChosenOpponent == "hard_bot")
                {
                    bot = new HardBot();
                }
                againstBot = true;
                timer_handlebot.Enabled = true;
            }
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
            if (!gameData.Fields[getFieldNum(sender)].IsTaken)
            {
                handleMove(sender);
                IfMoved = true;
            }
            if (IfMoved)
            {
                checkGameStatusAfterMove();
            }
        }

        private void checkGameStatusAfterMove()
        {
            int status = gameData.getGameStatus();
            // game in progress
            if (status == 0)
            {
                if (gameData.CurrentPlayer)
                    game_status.Text = "Player on move: X";
                else
                    game_status.Text = "Player on move: O";
                if (againstBot)
                {
                    botOnMove = true;
                }
            }
            // 'x' player wins
            else if (status == 1)
            {
                game_status.Text = "Player X won!";
                handleEndMatch(true);
            }
            else if (status == 2)
            // 'o' player wins
            {
                game_status.Text = "Player O won!";
                handleEndMatch(false);
            }
            else if (status == 3)
            // draw
            {
                game_status.Text = "Draw.";
                handleEndMatch(false, true);
            }
        }

        private void handleMove(object sender)
        {
            
            if (gameData.CurrentPlayer) // 'X' player
            {
                (sender as PictureBox).Image = Properties.Resources.field_x;
                gameData.Fields[getFieldNum(sender)].IsTaken = true;
                gameData.Fields[getFieldNum(sender)].Player = gameData.CurrentPlayer;
                gameData.CurrentPlayer = !gameData.CurrentPlayer;
                gameData.NumMoves++;
            }
            else // 'O' player
            {
                    
                (sender as PictureBox).Image = Properties.Resources.field_o;
                gameData.Fields[getFieldNum(sender)].IsTaken = true;
                gameData.Fields[getFieldNum(sender)].Player = gameData.CurrentPlayer;
                gameData.CurrentPlayer = !gameData.CurrentPlayer;
                gameData.NumMoves++;
            }
            
            
        }

        private void handleEndMatch(bool wonSign, bool isDraw=false)
        {
            if (isDraw)
            {
                gameData.ResultPlayer1 += 0.5;
                gameData.ResultPlayer2 += 0.5;
                label_winstatus.Text = $"Draw!";
            }
            else if (wonSign) // 'X' win
            {
                if (wonSign==Xplayer) 
                {
                    gameData.ResultPlayer1++;
                    label_winstatus.Text = $"{gameData.Player1} won round!";
                }
                else 
                { 
                    gameData.ResultPlayer2++;
                    label_winstatus.Text = $"{gameData.Player2} won round!";
                }
            }
            else if (!wonSign) // 'O' win
            {
                if (!wonSign == Xplayer) 
                {
                    gameData.ResultPlayer2++;
                    label_winstatus.Text = $"{gameData.Player2} won round!";
                }
                else 
                {
                    gameData.ResultPlayer1++;
                    label_winstatus.Text = $"{gameData.Player1} won round!";
                }
            }

            panel_board.Enabled = false;
            label_result.Text = $"{gameData.ResultPlayer1}:{gameData.ResultPlayer2}";
            panel_endround.Visible = true;
            btn_next.Text = "Next";

            // end game
            if ((gameData.ResultPlayer1 >= _dto.Bestof) || (gameData.ResultPlayer2 >= _dto.Bestof))
            {
                btn_next.Text = "End";
                IfEndGame = true;
                label_endgame_descr.Visible = true;
                label_endgame_descr.BringToFront();
                

                // 1st player wins
                if (gameData.ResultPlayer1 > gameData.ResultPlayer2)
                {
                    label_endgame_descr.Text = $"Player '{gameData.Player1}' won this game!";
                }
                // 2nd player wins
                else if (gameData.ResultPlayer1 < gameData.ResultPlayer2)
                {
                    label_endgame_descr.Text = $"Player '{gameData.Player2}' won this game!";
                }
                // draw
                else
                {
                    label_endgame_descr.Text = $"Draw!";
                }
            }



        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!IfEndGame)
            {
                startGame();
                panel_endround.Visible = false;
            }
            else
            {
                loadMenu(sender, e as FormClosedEventArgs);
            }
            
        }

        private void timer_handlebot_Tick(object sender, EventArgs e)
        {
            if (botOnMove)
            {
                int move = bot.getMove(gameData.Fields, gameData.CurrentPlayer);

                Control[] fld = this.Controls.Find($"field_{move}", true);
                (fld[0] as PictureBox).Image = Properties.Resources.field;

                if (gameData.CurrentPlayer) // 'X' player
                {
                    (fld[0] as PictureBox).Image = Properties.Resources.field_x;
                    gameData.Fields[move].IsTaken = true;
                    gameData.Fields[move].Player = gameData.CurrentPlayer;
                    gameData.CurrentPlayer = !gameData.CurrentPlayer;
                    gameData.NumMoves++;
                }
                else // 'O' player
                {

                    (fld[0] as PictureBox).Image = Properties.Resources.field_o;
                    gameData.Fields[move].IsTaken = true;
                    gameData.Fields[move].Player = gameData.CurrentPlayer;
                    gameData.CurrentPlayer = !gameData.CurrentPlayer;
                    gameData.NumMoves++;
                }

                checkGameStatusAfterMove();

                botOnMove = false;
                panel_board.Enabled = true;
            }
        }
    }
}
