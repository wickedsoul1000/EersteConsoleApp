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
            random random = new random();
            int number = random.Next(1,100);

            Console.WriteLine("choose a number between 1 and 100 to gues");
            int guess = int.Parse(Console.ReadLine());
          
            for (int í = guess; guess == number; i++) { 
            }
        }
    }
}
