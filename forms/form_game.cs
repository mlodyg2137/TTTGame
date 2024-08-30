using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        string dataSource = "Data Source=gameDB.db";
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
            gameData.BestOf = _dto.Bestof;
            round = 0;
            startGame();

            label_player1.Text = _dto.PlayerNickname;
            label_player2.Text = _dto.OpponentNickname;

            AddPlayerToDatabase(_dto.PlayerNickname);
            AddPlayerToDatabase(_dto.OpponentNickname);

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
            if ((gameData.ResultPlayer1 >= (int)(Math.Ceiling(_dto.Bestof / 2.0))) || (gameData.ResultPlayer2 >= (int)(Math.Ceiling(_dto.Bestof / 2.0))))
            {
                btn_next.Text = "End";
                IfEndGame = true;
                label_endgame_descr.Visible = true;
                label_endgame_descr.BringToFront();

                // 1st player wins
                if (gameData.ResultPlayer1 > gameData.ResultPlayer2)
                {
                    label_endgame_descr.Text = $"Player '{gameData.Player1}' won this game!";
                    UpdateRanking(false, gameData.Player1, gameData.Player2);
                }
                // 2nd player wins
                else if (gameData.ResultPlayer1 < gameData.ResultPlayer2)
                {
                    label_endgame_descr.Text = $"Player '{gameData.Player2}' won this game!";
                    UpdateRanking(false, gameData.Player2, gameData.Player1);
                }
                // draw
                else
                {
                    label_endgame_descr.Text = $"Draw!";
                    UpdateRanking(true, gameData.Player1, gameData.Player2);
                }

                AddGameToDatabase();
            }



        }

        private void AddPlayerToDatabase(string nickname)
        {
            if ((nickname == "Easy Bot") || (nickname == "Hard Bot"))
                return;
            using (var connection = new SQLiteConnection(dataSource))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM players WHERE nickname = @nickname";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@nickname", nickname);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show($"Player {nickname} exists in database.");
                            return; 
                        }
                    }

                    
                    string insertQuery = "INSERT INTO players (nickname, ranking_points, is_bot) VALUES (@nickname, 100, 0)";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@nickname", nickname);
                        int result = insertCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }

            }
        }

        private void AddGameToDatabase()
        {
            using (var connection = new SQLiteConnection(dataSource))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO games (best_of, player1_nick, player1_score, player2_nick, player2_score) VALUES (@best_of, @player1_nick, @player1_score, @player2_nick, @player2_score)";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@best_of", gameData.BestOf);
                        insertCommand.Parameters.AddWithValue("@player1_nick", gameData.Player1);
                        insertCommand.Parameters.AddWithValue("@player2_nick", gameData.Player2);
                        insertCommand.Parameters.AddWithValue("@player1_score", gameData.ResultPlayer1);
                        insertCommand.Parameters.AddWithValue("@player2_score", gameData.ResultPlayer2);
                        int result = insertCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }

            }
        }

        private void UpdateRanking(bool is_draw, string winner, string loser)
        {
            using (var connection = new SQLiteConnection(dataSource))
            {
                try
                {
                    connection.Open();

                    int WinnerRanking = 0;
                    int LoserRanking = 0;

                    string query = "SELECT ranking_points FROM players WHERE nickname = @nickname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nickname", winner);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            WinnerRanking = Convert.ToInt32(result);

                        command.Parameters.AddWithValue("@nickname", loser);
                        result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            LoserRanking = Convert.ToInt32(result);
                    }

                    // calculating new players rankings
                    double resultA = is_draw ? 0.5 : 1;
                    int K = 30;
                    int NewWinnerRanking = 0;
                    int NewLoserRanking = 0;
                    
                    double expectedA = 1.0 / (1.0 + Math.Pow(10, (LoserRanking - WinnerRanking) / 400.0));
                    double expectedB = 1.0 / (1.0 + Math.Pow(10, (WinnerRanking - LoserRanking) / 400.0));

                    NewWinnerRanking = (int)Math.Round(WinnerRanking + K * (resultA - expectedA));
                    NewLoserRanking = (int)Math.Round(LoserRanking + K * ((1 - resultA) - expectedB));

                    query = "UPDATE players SET ranking_points = @newRankingPoints WHERE nickname = @nickname";

                    using (SQLiteCommand checkCommand = new SQLiteCommand(query, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@newRankingPoints", NewWinnerRanking);
                        checkCommand.Parameters.AddWithValue("@nickname", winner);
                        checkCommand.ExecuteNonQuery();

                        checkCommand.Parameters.Clear();
                        checkCommand.Parameters.AddWithValue("@newRankingPoints", NewLoserRanking);
                        checkCommand.Parameters.AddWithValue("@nickname", loser);
                        checkCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
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
