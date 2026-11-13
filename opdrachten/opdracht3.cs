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
            string celsius

            Console.WriteLine("you wake up and ask your mother: goodMorning mom, how is the weather today? (sunny,rainy or cloudy)");
            weather = Console.ReadLine();

            Console.WriteLine($"its {weather} today");

            if (weather == "rainy" ) {
                Console.WriteLine("aahh i have to wear a jacket outside...");
                return;
            }

            if (weather == "cloudy") {
                Console.WriteLine("to bad i have to wear a jacket in this sad weather...");
            }
            if (weather = "sunny") {
                Console.WriteLine("ooh cool, and what is the tempeture? (in celsius you can just put the number(s) )");
                int temp;

                if (!int.TryParse(tempStr, out, temp)) {

                    do
                    {
                        Console.ReadLine("temp hes to be a number try again");
                        celsius = Console.ReadLine();
                    }
                    while (!int.TryParse(tempStr, out, temp);

                }
            }
        }
    }
}
