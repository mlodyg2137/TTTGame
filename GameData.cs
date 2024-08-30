using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    public class GameData
    {
        public string Player1 { set; get; }
        public string Player2 { set; get; }
        public double ResultPlayer1 { set; get; }
        public double ResultPlayer2 { set; get; }
        public int BestOf {  set; get; }
        public Field[] Fields { set; get; }
        public bool CurrentPlayer { set; get; } // true - 'X' player, false - 'O' player
        public int NumMoves { set; get; }

        public GameData() 
        {
            Fields = new Field[9];
            CurrentPlayer = true;
            NumMoves = 0;
        }

        public int getGameStatus()
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
                        if (Fields[idx].Player) return 1;
                        else return 2;
                    }
                }
                //column
                if ((Fields[i].IsTaken == true) && (Fields[i + 3].IsTaken == true) && (Fields[i + 6].IsTaken == true))
                {
                    if ((Fields[i].Player == Fields[i + 3].Player) && (Fields[i + 3].Player == Fields[i + 6].Player))
                    {
                        if (Fields[i].Player) return 1;
                        else return 2;
                    }
                }
            }
            //diagonal
            if ((Fields[0].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[8].IsTaken == true))
            {
                if ((Fields[0].Player == Fields[4].Player) && (Fields[4].Player == Fields[8].Player))
                {
                    if (Fields[0].Player) return 1;
                    else return 2;
                }
            }
            if ((Fields[2].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[6].IsTaken == true))
            {
                if ((Fields[2].Player == Fields[4].Player) && (Fields[4].Player == Fields[6].Player))
                {
                    if (Fields[2].Player) return 1;
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

        public void loadFields()
        {
            for (int i = 0; i < 9; i++)
            {
                Fields[i] = new Field($"field_{i}", i, false);
            }
        }
    }
}
