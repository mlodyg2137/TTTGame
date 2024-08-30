using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    internal class EasyBot : Bot
    {
        public EasyBot() { }
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
