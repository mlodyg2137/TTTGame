using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    internal class HardBot : Bot
    {
        public HardBot() { }
        public override int getMove(Field[] fields, bool player)
        {
            Field[] temp_fields = (Field[])fields.Clone();

            int bestMove = -1;
            int bestScore = int.MinValue;

            for (int i = 0; i < temp_fields.Length; i++)
            {
                if (!temp_fields[i].IsTaken)
                {
                    // Symulacja ruchu
                    temp_fields[i].IsTaken = true;
                    temp_fields[i].Player = player;

                    int score = Minimax(temp_fields, false, player);

                    // Cofnięcie ruchu
                    temp_fields[i].IsTaken = false;
                    temp_fields[i].Player = false;

                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }

            return bestMove;
        }
        private int Minimax(Field[] board, bool isMaximizing, bool player)
        {
            bool? winner = checkWinner(board);

            if (winner != null)
            {
                if (winner == player) return 1;
                if (winner == !player) return -1;
                return 0;
            }

            int bestScore = isMaximizing ? int.MinValue : int.MaxValue;

            for (int i = 0; i < board.Length; i++)
            {
                if (!board[i].IsTaken)
                {
                    // Symulacja ruchu
                    board[i].IsTaken = true;
                    board[i].Player = isMaximizing ? player : !player;

                    int score = Minimax(board, !isMaximizing, player);

                    // Cofnięcie ruchu
                    board[i].IsTaken = false;
                    board[i].Player = false;

                    bestScore = isMaximizing ? Math.Max(score, bestScore) : Math.Min(score, bestScore);
                }
            }

            return bestScore;
        }

        private bool? checkWinner(Field[] Fields)
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
                if ((Fields[idx].IsTaken == true) && (Fields[idx + 1].IsTaken == true) && (Fields[idx + 2].IsTaken == true))
                {
                    if ((Fields[idx].Player == Fields[idx + 1].Player) && (Fields[idx + 1].Player == Fields[idx + 2].Player))
                    {
                        if (Fields[idx].Player) return true;
                        else return false;
                    }
                }
                //column
                if ((Fields[i].IsTaken == true) && (Fields[i + 3].IsTaken == true) && (Fields[i + 6].IsTaken == true))
                {
                    if ((Fields[i].Player == Fields[i + 3].Player) && (Fields[i + 3].Player == Fields[i + 6].Player))
                    {
                        if (Fields[i].Player) return true;
                        else return false;
                    }
                }
            }
            //diagonal
            if ((Fields[0].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[8].IsTaken == true))
            {
                if ((Fields[0].Player == Fields[4].Player) && (Fields[4].Player == Fields[8].Player))
                {
                    if (Fields[0].Player) return true;
                    else return false;
                }
            }
            if ((Fields[2].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[6].IsTaken == true))
            {
                if ((Fields[2].Player == Fields[4].Player) && (Fields[4].Player == Fields[6].Player))
                {
                    if (Fields[2].Player) return true;
                    else return false;
                }
            }

            // Checking draw status
            int TakenFields = 0;
            foreach (Field field in Fields)
            {
                if (field.IsTaken == true)  TakenFields++;
            }

            if (TakenFields == 9) return false;

            // Game in progress
            return null;

        }
    }
}
