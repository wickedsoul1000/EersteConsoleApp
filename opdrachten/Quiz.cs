
using System;

namespace main
{
    public class Som
    {
        private float nummer1;
        private float nummer2;
        private string somType;

        public Som(float getal1, float getal2, string type)
        {
            nummer1 = getal1;
            nummer2 = getal2;
            somType = type;
            string op = Console.ReadLine();
        }
    }
    public class Quiz
    {
        private float result;
        private float antwoord;
        private float score;

        private Random random = new Random();

        public Quiz()
        {
            result = 0;
            antwoord = 0;
            score = 0;
        }

        public void ShowQuiz()
        {
            string op = Console.ReadLine();
            while (op != "-" && op != "+" && op != "/" && op != "*") {
                Console.WriteLine("choose a valid operator.");
                op = Console.ReadLine();
            }

            for (int looping = 0; looping < 5; looping++)
            {
                float nummer1 = random.Next(1, 11);
                float nummer2 = random.Next(1, 11);


                Console.WriteLine($"What is {nummer1} {op} {nummer2} =");

                float.TryParse(Console.ReadLine(), out antwoord);

                switch (op)
                {
                    case "+":
                        result = nummer1 + nummer2;
                        break;

                    case "-":
                        result = nummer1 - nummer2;
                        break;

                    case "*":
                        result = nummer1 * nummer2;
                        break;

                    case "/":
                        result = nummer1 / nummer2;
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
                Console.WriteLine($"You have {score} points. You did alright");
            }
            else
            {
                Console.WriteLine($"You have {score} points. You did bad");
            }
        }
        public bool CheckAnswer(float antwoord)
        {

            return result == antwoord;
        }
    }
}