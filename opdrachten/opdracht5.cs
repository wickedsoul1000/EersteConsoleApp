using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht5
    {
        public void Start() {
            Console.WriteLine("Choose your first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your second number");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
        }
    }
}
