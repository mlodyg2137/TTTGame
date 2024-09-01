using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    /// <summary>
    /// Reprezentuje dane i logikę gry "Kółko i krzyżyk" (Tic Tac Toe).
    /// Przechowuje informacje o graczach, ich wynikach, stanie planszy oraz aktualnym stanie gry.
    /// </summary>
    public class GameData
    {
        /// <summary>
        /// Przechowuje nazwę pierwszego gracza.
        /// </summary>
        public string Player1 { set; get; }

        /// <summary>
        /// Przechowuje nazwę drugiego gracza.
        /// </summary>
        public string Player2 { set; get; }

        /// <summary>
        /// Przechowuje wynik pierwszego gracza.
        /// </summary>
        public double ResultPlayer1 { set; get; }

        /// <summary>
        /// Przechowuje wynik drugiego gracza.
        /// </summary>
        public double ResultPlayer2 { set; get; }

        /// <summary>
        /// Przechowuje liczbę rund, które są rozgrywane w grze.
        /// </summary>
        public int BestOf { set; get; }

        /// <summary>
        /// Tablica przechowująca stan wszystkich pól na planszy.
        /// </summary>
        public Field[] Fields { set; get; }

        /// <summary>
        /// Określa, który gracz jest aktualnie w ruchu.
        /// True dla gracza "X", False dla gracza "O".
        /// </summary>
        public bool CurrentPlayer { set; get; } // true - 'X' player, false - 'O' player

        /// <summary>
        /// Liczba wykonanych ruchów w aktualnej rundzie.
        /// </summary>
        public int NumMoves { set; get; }

        /// <summary>
        /// Konstruktor inicjalizujący nową instancję klasy <see cref="GameData"/> z domyślnymi ustawieniami.
        /// Tworzy tablicę pól gry, ustawia aktualnego gracza na "X" oraz liczbę ruchów na 0.
        /// </summary>
        public GameData()
        {
            Fields = new Field[9];
            CurrentPlayer = true;
            NumMoves = 0;
        }

        /// <summary>
        /// Metoda sprawdzająca aktualny stan gry.
        /// Możliwe zwracane wartości:
        /// 0 - Gra w toku.
        /// 1 - Wygrana gracza "X".
        /// 2 - Wygrana gracza "O".
        /// 3 - Remis.
        /// </summary>
        /// <returns>Aktualny stan gry jako liczba całkowita.</returns>
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

        /// <summary>
        /// Inicjalizuje tablicę <see cref="Fields"/>, tworząc nowe instancje obiektów <see cref="Field"/> dla każdego pola na planszy.
        /// </summary>
        public void loadFields()
        {
            for (int i = 0; i < 9; i++)
            {
                Fields[i] = new Field($"field_{i}", i, false);
            }
        }
    }
}
