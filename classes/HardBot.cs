using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    /// <summary>
    /// Reprezentuje trudnego bota w grze "Kółko i krzyżyk", który wykorzystuje algorytm minimax do wybrania najlepszego możliwego ruchu.
    /// </summary>
    internal class HardBot : Bot
    {
        public HardBot() { }
        private const int MaxDepth = 5;
        /// <summary>
        /// Zwraca indeks pola, na które bot zdecyduje się postawić swój znak, używając algorytmu minimax.
        /// </summary>
        /// <param name="Fields">Tablica reprezentująca stan wszystkich pól na planszy.</param>
        /// <param name="player">Aktualny gracz (true dla "X", false dla "O").</param>
        /// <returns>Indeks pola, na które bot zdecyduje się wykonać ruch.</returns>
        public override int getMove(Field[] Fields, bool player)
        {
            Field[] fields = (Field[])Fields.Clone();
            int bestMove = -1;
            int bestValue = player ? int.MinValue : int.MaxValue;

            for (int i = 0; i < fields.Length; i++)
            {
                if (!fields[i].IsTaken)
                {
                    fields[i].IsTaken = true;
                    fields[i].Player = player;

                    int moveValue = Minimax(fields, 0, !player);

                    fields[i].IsTaken = false;

                    if (player && moveValue > bestValue)
                    {
                        bestValue = moveValue;
                        bestMove = i;
                    }
                    else if (!player && moveValue < bestValue)
                    {
                        bestValue = moveValue;
                        bestMove = i;
                    }
                }
            }

            return bestMove;
        }

        /// <summary>
        /// Algorytm minimax, który ocenia najlepszy możliwy ruch dla bota.
        /// </summary>
        /// <param name="fields">Tablica reprezentująca stan wszystkich pól na planszy.</param>
        /// <param name="depth">Głębokość rekursji.</param>
        /// <param name="isMaximizing">Flaga wskazująca, czy bot maksymalizuje (true) czy minimalizuje (false) wynik.</param>
        /// <returns>Ocena ruchu jako liczba całkowita.</returns>
        private int Minimax(Field[] fields, int depth, bool isMaximizing)
        {
            int score = Evaluate(fields);
            if (score == 10 || score == -10 || IsFull(fields))
            {
                return score;
            }

            if (depth == MaxDepth)
            {
                return score;
            }

            if (isMaximizing)
            {
                int best = int.MinValue;
                for (int i = 0; i < fields.Length; i++)
                {
                    if (!fields[i].IsTaken)
                    {
                        fields[i].IsTaken = true;
                        fields[i].Player = true;

                        best = Math.Max(best, Minimax(fields, depth + 1, false));

                        fields[i].IsTaken = false;
                    }
                }
                return best;
            }
            else
            {
                int best = int.MaxValue;
                for (int i = 0; i < fields.Length; i++)
                {
                    if (!fields[i].IsTaken)
                    {
                        fields[i].IsTaken = true;
                        fields[i].Player = false;

                        best = Math.Min(best, Minimax(fields, depth + 1, true));

                        fields[i].IsTaken = false;
                    }
                }
                return best;
            }
        }

        /// <summary>
        /// Ocena stanu planszy w kontekście możliwych wygranych lub przegranych.
        /// </summary>
        /// <param name="Fields">Tablica reprezentująca stan wszystkich pól na planszy.</param>
        /// <returns>Ocena stanu planszy: 10, -10 lub 0.</returns>
        private int Evaluate(Field[] Fields)
        {
            for (int i = 0; i < 3; i++)
            {
                int idx = 3 * i;

                //row
                if ((Fields[idx].IsTaken == true) && (Fields[idx + 1].IsTaken == true) && (Fields[idx + 2].IsTaken == true))
                {
                    if ((Fields[idx].Player == Fields[idx + 1].Player) && (Fields[idx + 1].Player == Fields[idx + 2].Player))
                    {
                        if (Fields[idx].Player) return 10;
                        else return -10;
                    }
                }
                //column
                if ((Fields[i].IsTaken == true) && (Fields[i + 3].IsTaken == true) && (Fields[i + 6].IsTaken == true))
                {
                    if ((Fields[i].Player == Fields[i + 3].Player) && (Fields[i + 3].Player == Fields[i + 6].Player))
                    {
                        if (Fields[i].Player) return 10;
                        else return -10;
                    }
                }
            }
            //diagonal
            if ((Fields[0].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[8].IsTaken == true))
            {
                if ((Fields[0].Player == Fields[4].Player) && (Fields[4].Player == Fields[8].Player))
                {
                    if (Fields[0].Player) return 10;
                    else return -10;
                }
            }
            if ((Fields[2].IsTaken == true) && (Fields[4].IsTaken == true) && (Fields[6].IsTaken == true))
            {
                if ((Fields[2].Player == Fields[4].Player) && (Fields[4].Player == Fields[6].Player))
                {
                    if (Fields[2].Player) return 10;
                    else return -10;
                }
            } 

            // Game in progress
            return 0;
        }

        /// <summary>
        /// Sprawdza, czy wszystkie pola na planszy są zajęte.
        /// </summary>
        /// <param name="fields">Tablica reprezentująca stan wszystkich pól na planszy.</param>
        /// <returns>True, jeśli wszystkie pola są zajęte; w przeciwnym razie false.</returns>
        private bool IsFull(Field[] fields)
        {
            return fields.All(field => field.IsTaken);
        }

    }
}
