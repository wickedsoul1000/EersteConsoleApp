using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class player
{
    private string name;
    private int level;
    private int lives;
    public player(string playerName, int playerLevel, int livess)
    {
        name = playerName;
        level = playerLevel;
        lives = livess;
    }
    public void ShowStats()
    {
        Console.WriteLine($"Player: {name}, Level {level} and you have {lives} lives");
    }
}
