using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    /// <summary>
    /// Reprezentuje obiekt transferu danych (DTO) używany do przenoszenia danych pomiędzy formularzami w aplikacji.
    /// Zawiera informacje o graczach oraz ustawieniach gry, które są przekazywane pomiędzy różnymi widokami.
    /// </summary>
    public class DataTransferObject
    {
        /// <summary>
        /// Przechowuje pseudonim gracza.
        /// </summary>
        public string PlayerNickname { get; set; }

        /// <summary>
        /// Przechowuje pseudonim przeciwnika.
        /// </summary>
        public string OpponentNickname { get; set; }

        /// <summary>
        /// Przechowuje informację o wybranym przeciwniku (np. AI lub inny gracz).
        /// </summary>
        public string ChosenOpponent { get; set; }

        /// <summary>
        /// Przechowuje liczbę rund (best of), które są ustawione dla gry.
        /// </summary>
        public int Bestof { get; set; }

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="DataTransferObject"/> z domyślnymi wartościami.
        /// </summary>
        public DataTransferObject() { }
    }
}
