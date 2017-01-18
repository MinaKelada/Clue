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
        public List<string> askLog;
        public List<string> cannotHave;
        public List<string> mightHave;
        public string name;
        public Player()
        {
            Cards = new List<string>();
            cannotHave = new List<string>();
            askLog = new List<string>();
            mightHave = new List<string>();
            cardCount = 0;
            name = "";
        }
        public Player(string n, int count)
        {
            Cards = new List<string>();
            cannotHave = new List<string>();
            askLog = new List<string>();
            cardCount = count;
            for (int i = 0; i < count; i++)
            {
                Cards.Add("Unknown Card");
            }
                name = n;
        }
    }
}
