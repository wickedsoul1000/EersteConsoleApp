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
            public void Start()
        {
            Console.WriteLine("what kind of operator do you want to use? (+, -, /, *)");
            Quiz quiz = new Quiz();

            quiz.ShowQuiz();
        }
    }
}