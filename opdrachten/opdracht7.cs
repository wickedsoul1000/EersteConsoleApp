using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht7
    {
        public void Start() {
            int highest = 0;
            int mostRoll = 0;
            int maxNum = 100;
            int[] numbers = new int[maxNum + 1];
            Random random = new Random();

            for (int i = 0; i < 100; i++) {
                int randomNum = random.Next(maxNum + 1);

                Console.WriteLine(randomNum);

                numbers[randomNum]++;
            }

            //showing the results
            for (int i = 1; i <= maxNum; i++) {
                if (numbers[i] > highest) {
                    highest = numbers[i];
                    mostRoll = i;
                }
                double percentage = (double)numbers[i] / 100 * 100;
                Console.WriteLine($"numbers {i} appeared {numbers[i]} times ");
                Console.WriteLine($"Number {i}: {percentage}%");
            }
            Console.WriteLine($"most roll = {highest}");
        }
    }
}
