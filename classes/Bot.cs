using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    internal abstract class Bot
    {
        public abstract int getMove(Field[] fields, bool player);
    }
}
