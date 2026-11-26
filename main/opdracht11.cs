using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace main
{

    internal class opdracht11
    {
        float result;
        float antwoord;
        float score;
        public void Start()
        {

            Random symbols = new Random();
            Random sommen = new Random();

            string[] operators = { "+", "-", "*", "/" };

            for (int looping = 0; looping < 5; looping++)
            {

             float nummer1 = sommen.Next(1, 11);
            float nummer2 = sommen.Next(1, 11);

                string selectedOperators = operators[symbols.Next(operators.Length)];


                Console.WriteLine($"what is {nummer1} {selectedOperators} {nummer2} =");
            float.TryParse(Console.ReadLine(), out antwoord);
       
                switch (selectedOperators)
                {

                    case "+":
                        Console.WriteLine(nummer1 + nummer2);
                        result = nummer1 + nummer2;
                        break;

                    case "-":
                        Console.WriteLine(nummer1 - nummer2);
                        result = nummer1 - nummer2;
                        break;

                    case "/":
                        Console.WriteLine(nummer1 / nummer2);
                        result = nummer1 / nummer2;
                        break;

                    case "*":
                        Console.WriteLine((double)nummer1 * nummer2);
                        result = nummer1 * nummer2;
                        break;
                }

                if (result != antwoord)
                {
                    Console.WriteLine("Incorrect");
                    continue;
                }

                Console.WriteLine("Correct");
                score++;
                Console.WriteLine($"You got {score} points");
            }

            if (score > 2)
            {
                Console.WriteLine($"You have {score} points you did alright");
            }

            else {
                Console.WriteLine($"you have {score} points. You did bad");
            }

        }
    }
}