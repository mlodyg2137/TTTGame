using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    internal class EasyBot : Bot
    {
        /// <summary>
        /// Reprezentuje prostego bota, który wykonuje losowe ruchy.
        /// </summary>
        public EasyBot() { }
        /// <summary>
        /// Zwraca indeks pola, na które bot zdecyduje się postawić swój znak. Wybiera losowy dostępny ruch.
        /// </summary>
        /// /// <param name="fields">Tablica reprezentująca stan wszystkich pól na planszy.</param>
        /// <param name="player">Aktualny gracz (true dla "X", false dla "O").</param>
        /// <returns>Indeks pola, na które bot zdecyduje się wykonać ruch.</returns>
        public override int getMove(Field[] fields, bool player)
        {
            List<int> availableMoves = new List<int>();
            for (int i=0; i<9; i++)
            {
                if (!fields[i].IsTaken)
                {
                    availableMoves.Add(i);
                }
            }
            Random random = new Random();
            return availableMoves[random.Next(availableMoves.Count)];
        }
    }
}
