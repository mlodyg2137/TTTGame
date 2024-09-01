using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    /// <summary>
    /// Reprezentuje pojedyncze pole na planszy w grze "Kółko i krzyżyk".
    /// Przechowuje informacje o numerze pola, jego stanie (czy jest zajęte) oraz który gracz (X lub O) zajął to pole.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Nazwa pola, np. "field_0", "field_1".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Numer pola na planszy (0...8), numeracja od dolnego lewego do górnego prawego rogu.
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// Flaga określająca, czy pole jest zajęte.
        /// </summary>
        public bool IsTaken { get; set; }

        /// <summary>
        /// Gracz, który zajął pole. True oznacza gracza "X", False oznacza gracza "O".
        /// </summary>
        public bool Player { get; set; }

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="Field"/> z określoną nazwą, numerem i stanem zajętości.
        /// </summary>
        /// <param name="name">Nazwa pola.</param>
        /// <param name="num">Numer pola na planszy.</param>
        /// <param name="istaken">Określa, czy pole jest zajęte.</param>
        public Field(string name, int num, bool istaken)
        {
            Name = name;
            Num = num;
            IsTaken = istaken;
        }

        /// <summary>
        /// Wyświetla informacje o polu w konsoli.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Num: {Num}, IsTaken: {IsTaken}");
        }
    }
}
