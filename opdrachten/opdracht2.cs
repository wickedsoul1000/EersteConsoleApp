using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class opdracht2
{
 
    public void Start()
    {
        string Choice = "";
        string Choice2 = "";

        string[] rooms = { "bathroom", "living room", "kitchen", "outside door", "game room" };
        string[] winRooms = { "kitchen", "game room" };
        bool goBack = true;

        while (goBack)
        {
            Console.WriteLine("you can go to the: bathroom, living room, kitchen, bedroom, game room. Where do you choose to go?");
             Choice = Console.ReadLine().ToLower();

            while (Choice != rooms[0] && Choice != rooms[1] && Choice != rooms[2] && Choice != rooms[3] && Choice != rooms[4])
            {
                Console.WriteLine("type the rooms that are given");
                Choice = Console.ReadLine().ToLower();

            }
            Console.WriteLine($"you are in the room {Choice} want to go back (YES/NO)");
            Choice2 = Console.ReadLine().ToLower();

            if (Choice2 == "yes")
            {
                goBack = true;
                continue;
            }

            if (Choice != winRooms[0] && Choice2 == "no")
            {
                goBack = false;
                Console.WriteLine($"you are in the {Choice} you lost");
            }

            else
            {
                goBack = false;

            }
        }
          
            if (Choice == winRooms[0] || Choice == winRooms[1])
            {
                Console.WriteLine("YOU WON");
            }
            else
            {
                Console.WriteLine("you lost");
                return;
            }
        }
    }