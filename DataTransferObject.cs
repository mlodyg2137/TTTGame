using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    internal class DataTransferObject
    {
        public string ChosenOpponent {  get; set; }
        public GameData GameD { get; set; }
        public DataTransferObject() { }
    }
}
