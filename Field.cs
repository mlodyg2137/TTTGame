using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    public class Field
    {
        public string Name { get; set; }
        public int Num { get; set; } // number of field 0...8 (from bottom left to top right)
        public bool IsTaken { get; set; }
        public bool Player { get; set; } // true - X, false - O
        
        public Field(string name, int num, bool istaken)
        {
            Name = name;
            Num = num;
            IsTaken = istaken;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Num: {Num}, IsTaken: {IsTaken}");
        }
    }
}
