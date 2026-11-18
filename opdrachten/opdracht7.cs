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
            int maxNum = 6;
            int mostRolled = 0;
            int totalRolls = 100;

            int[] numbers = new int[maxNum + 1];
            Random random = new Random();

            for (int i = 0; i < totalRolls; i++) {
                int randomNum = random.Next(maxNum + 1);

                numbers[randomNum]++;
            }

            //showing results
            for (int i = 1; i <= maxNum; i++) {
                double percentage = (double)6 / 100 * numbers[i];
                Console.WriteLine($"numbers {i} appeared {numbers[i]} times ");
                Console.WriteLine($"Number {i}: {percentage}%");

                if (numbers[i] > highest) {
                    highest = numbers[i];
                    mostRolled = i;
                }
            }
            Console.WriteLine($"most roll = {mostRolled}");
        }
    }
}
