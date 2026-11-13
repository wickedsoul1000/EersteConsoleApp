using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht2
    {
        public void Start() {
            string door;
            string[] rooms = { "room1", "room2", "room3", "room4" };
            string[] answers = { "door1", "door3", "door2", "door6"};

            Console.WriteLine("hello young traveler. there are 4 rooms, every room there is 5 - 10 Doors, every door goes to somewhere BUT only one will lead you through it alive choose the correct one to live.");
            Console.WriteLine("now choose..... (room 1..... 5 doors)");

            door = Console.ReadLine();

            do
            {
                if (door != answers[0]) {
                    Console.WriteLine($"you entered the {door} and you died of a tiger attack...... try again");
                    door = Console.ReadLine();
                }
            }

            while (door != answers[0]);

            Console.WriteLine("good you survived the first room now onto the second one.... (there are 6 rooms to choose from)");
            door = Console.ReadLine();

            do
            {
                if (door != answers[1])
                {
                    Console.WriteLine($"you entered the {door} and you died of a spider bite?? or what was that?...... try again");
                    door = Console.ReadLine();
                }
            }

            while (door != answers[1]);


            Console.WriteLine("not bad you survived the second room aswell. Now onto the third one.... (there are 7 rooms to choose from)");
            door = Console.ReadLine();

            do
            {
                if (door != answers[2])
                {
                    Console.WriteLine($"you entered the {door} and you died because of poisen?? no....a person...... try again");
                    door = Console.ReadLine();
                }
            }

            while (door != answers[2]);

            Console.WriteLine("intressting.... now the final room... good luck (there are 10 doors to choose from)");
            door = Console.ReadLine();

            do
            {
                if (door != answers[3])
                {
                    Console.WriteLine($"you entered the {door} and you died because of ???......unkown...HIM...... try again");
                    door = Console.ReadLine();
                }
            }

            while (door != answers[3]);
            Console.WriteLine("congrats traveler.... it is now time to end it here you cant go pass this point..... i am sorry but i have to end you..... you shouldn't have come here....");
            return;

        }
    }
}
