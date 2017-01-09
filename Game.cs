using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    public static class Game
    {
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
        }
    }
}
