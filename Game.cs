using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    public static class Game
    {
        public delegate void renameHandler(object source, EventArgs args);
        public static event renameHandler renamed;
        public static string[] locationArray;
        public static string[] suspectsArray;
        public static string[] objectsArray;
        public static List<Player> players;
        public static List<string> openCards;
        public static List<string> askLog;
        public static int playerNumber;
        public static int totalCardCount;
        public static int perPlayerCardCount;
        static Game()
        {
            locationArray = new string[] {"Great Plains","Pacific NorthWest","Rocky Mountains","Great Lakes", "New England",
                                       "Mid-Atlantic","SouthEast","SouthWest","West Coast"};
            suspectsArray = new string[] { "Charlie", "Bobby", "Castiel", "Dean", "Sam", "Crowley" };
            objectsArray = new string[] { "Revolvers", "Ruby's Knife", "Demon Table", "John Winchester's Journal", "First Blade", "Four Horsemen Rings" };
            players = new List<Player>();
            openCards = new List<string>();
            askLog = new List<string>();
            playerNumber = 0;
            totalCardCount = locationArray.Length;
            totalCardCount += suspectsArray.Length;
            totalCardCount += objectsArray.Length;
            totalCardCount -= 3;
            perPlayerCardCount = 0;
        }
        public static void setInitialState(string playNumber, string playerName)
        {
            playerNumber = int.Parse(playNumber);
            double total = totalCardCount;
            double number = playerNumber;
            perPlayerCardCount = (int)Math.Floor(total / number);
            players.Add(new Player(playerName, perPlayerCardCount));
            for (int i = 1; i < playerNumber; i++)
            {
                string name = "Player ";
                name += i.ToString();
                players.Add(new Player(name, Game.perPlayerCardCount));
            }
            int handedCards = perPlayerCardCount * playerNumber;
            int remainingCards = totalCardCount - handedCards;
            if (remainingCards != 0)
            {
                for (int i = 0; i < remainingCards; i++)
                {
                    Game.openCards.Add("Unknown Card");
                }
            }
        } //end of setInitialState
        public static string[] getAllPlayerNames()
        {
            string[] all = new string[playerNumber];
            for(int i = 0;i < playerNumber; i++)
            {
                all[i] = players[i].name;
            }
            return all;
        }
        public static void raiseRename()
        {
            renamed(null, EventArgs.Empty);
        }
        public static void Dispose()
        {
            renamed = null;
        }
        public static string[] getAllCards()
        {
            string[] all = new string[totalCardCount+3];
            int i = 0;
            foreach(string l in locationArray)
            {
                all[i] = l;
                i++;
            }
            foreach(string o in objectsArray)
            {
                all[i] = o;
                i++;
            }
            foreach(string s in suspectsArray)
            {
                all[i] = s;
                i++;
            }
            return all;
        }
        public static string assignCard(string card, string playerName)
        {
            string i = null;
            foreach(Player p in players)
            {
                foreach(string c in p.Cards)
                {
                    if(c == card)
                    {
                        i = "Cannot assign the same card to two different players";
                        return i;
                    }
                }
            }
            foreach(Player p in players)
            {
                if(p.name == playerName)
                {
                    bool rem = p.Cards.Remove("Unknown Card");
                    if (!rem)
                    {
                        i = p.name + " does not have any available card slots";
                        return i;
                    }
                    p.Cards.Add(card);
                    break;
                }
            }
            return i;
        }
    }
   
}
