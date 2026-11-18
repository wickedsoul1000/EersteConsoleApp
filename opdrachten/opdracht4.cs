using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht4
    {
        public void leeftijdCatagorie(int age) {
            if (age >= 18 && age <= 25)
            {
                Console.WriteLine("you're getting older but hey, you still get energy to have fun right?");

            }
            else if (age > 25 && age < 40)
            {
                Console.WriteLine("i see you have 3 kids now ey, but you still can have sometimes fun with your friends right?");
            }
            else if (age >= 40 && age < 65)
            {
                Console.WriteLine("almost retiring ey");

            }
            else if (age > 70)
            {
                Console.WriteLine("maybe its time to to rest the last years you have");
            }

        }
        public void Start() {

            Console.WriteLine("whats your birthyear? (YYYY)");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int birthYear) &&
                birthYear > 0 &&
                birthYear <= DateTime.Now.Year)
            {
                int age = DateTime.Now.Year - birthYear;
                leeftijdCatagorie(age);
                if (age <= 18)
                {
                    Console.WriteLine($"you are {age} years old, sorry but you can't vote");
                }


            }
            else {
                Console.WriteLine("put a real date");
            }

        }
    }
}
