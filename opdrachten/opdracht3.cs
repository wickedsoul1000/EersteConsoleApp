using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht3
    {
        public void Start()
        {

            string weather;
            string retry;
            string celsius;

            Console.WriteLine("you wake up and ask your mother: goodMorning mom, how is the weather today? (sunny,rainy or cloudy)");
            weather = Console.ReadLine().ToLower();

            do
            {
                if (weather != "sunny" || weather != "rainy" || weather != "cloudy") {
                    Console.WriteLine("choose between the given weather choises");
                    return;
                }
            }
            while (weather != "sunny" || weather != "rainy" || weather != "cloudy");

            Console.WriteLine($"its {weather} today");

            if (weather == "rainy" ) {
                Console.WriteLine("aahh i have to wear a jacket outside...");
                return;
            }

            if (weather == "cloudy") {  
                Console.WriteLine("to bad i have to wear a jacket in this sad weather...");
            }
            if (weather == "sunny") {
                Console.WriteLine("ooh cool, and what is the tempeture? (in celsius you can just put the number(s) )");
                int temp;
                celsius = Console.ReadLine();

                while (!int.TryParse(celsius, out temp)) {
                    Console.WriteLine("temp has to be a number, try again");
                    celsius = Console.ReadLine();
                }

                if (temp >= 20) {
                    Console.WriteLine("its nice and warm don't forget sunscreen");
                    return;
                }

                else if (temp <20) {
                    Console.WriteLine("oh you still need to put a jacked on but dont forget sunscreen, to be sure you know?");
                    return;
                }
            }
        }
    }
}
