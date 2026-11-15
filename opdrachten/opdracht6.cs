using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht6
    {
        public void Start() {
            int num;

            Console.WriteLine("choose a max number to choose from");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please enter a number!");

            }
            int maxNum = num;
            Random random = new Random();
            int number = random.Next(maxNum);

            Console.WriteLine($"choose a number between 0 and {maxNum} to guess");
            int guess = int.Parse(Console.ReadLine());


            for (int i = 0; i <= maxNum; i++)
            {
                do
                {
                    if (guess != number)
                    {
                        i++;
                        Console.WriteLine($"sorry you are wrong try again. you guessed {i} times");
                        guess = int.Parse(Console.ReadLine());
                    }
                    if (guess > number) {
                        Console.WriteLine("guess lower");
                    }
                    if (guess < number) {
                        Console.WriteLine("guess higher");
                    }
                }
                while (guess != number);
             
            }
            Console.WriteLine("you are correct");

        }
    }
}
