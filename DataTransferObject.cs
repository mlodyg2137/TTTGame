using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTGame
{
    public class DataTransferObject
    {
        public string PlayerNickname { get; set; }
        public string OpponentNickname { get; set; }
        public string ChosenOpponent { get; set; }
        
        public DataTransferObject() { }
    }
}
