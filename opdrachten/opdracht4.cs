using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht4
    {
        public void Start() {

            Console.WriteLine("whats your birthdate? (DD/MM/YYY)");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthdate))
            {

                int age = DateTime.Now.Year - birthdate.Year;
                if (DateTime.Now < birthdate.AddYears(age))
                {
                    age--;
                }
                if (!(age >= 18))
                {
                    Console.WriteLine($"you are {age} years old, sorry but you can't vote");
                }
                else {
                    Console.WriteLine($"you're {age} years old, you are old enough to vote");
                }

                if (age >= 25 && age < 30) {
                    Console.WriteLine("you're getting older but hey, you still get energy to have fun right?");

                }
                else if (age >= 30 && age < 40) {
                    Console.WriteLine("i see you have 3 kids now ey, but you still can have sometimes fun with your friends right?");
                }
                else if (age >= 40 && age < 65) {
                    Console.WriteLine("almost retiring ey");

                }
                else if (age > 70) {
                    Console.WriteLine("maybe its time to to rest the last years you have");
                }


            }
            else {
                Console.WriteLine("put a real date");
            }   


        }
    }
}
