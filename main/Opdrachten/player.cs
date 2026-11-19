using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Opdrachten
{
   public class player
    {
        string name;
        int level;
        int lives;
        public player(string playerName, int playerLevel, int livess)
        {
            name = playerName;
            level = playerLevel;
            lives = livess;
        }

           public void Start()
        {
            player player1 = new player("wicked", 5, 9);
            player player2 = new player("soul", 15, 3);

            player1.ShowStats();
            player2.ShowStats();
        }
        public void ShowStats()
        {
            Console.WriteLine($"Player: {name}, Level {level} and you have {lives} lives");
        }
    }
}
