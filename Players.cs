using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    public class Player
    {
        int cardCount;
        public List<string> Cards;
        public string name;
        public Player()
        {
            Cards = new List<string>();
            cardCount = 0;
            name = "";
        }
        public Player(string n, int count)
        {
            Cards = new List<string>();
            cardCount = count;
            for (int i = 0; i < count; i++)
            {
                Cards.Add("Unknown Card");
            }
                name = n;
        }
    }
}
