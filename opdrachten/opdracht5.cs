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
            string input = "";
            string inputNum = "";

            Console.WriteLine("Choose the table you want to use");

            input = Console.ReadLine();
            if ((int.TryParse(input, out int table))) {
                Console.WriteLine("type a number");
            }

                Console.WriteLine("Choose to how much you want to go");
                inputNum = Console.ReadLine();
                if (int.TryParse(inputNum, out int num))
                {
                    Console.WriteLine("type a number");
                }

                for (num = 0; num <= table; num++)
                {
                    Console.WriteLine($"{table} x {num} = {table * num}");
                }
                }
            }
        }
