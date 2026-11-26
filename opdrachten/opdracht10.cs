using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht10
    {
        public void Start()
        {
            string reverse = "";

            Console.WriteLine("type a word: ");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

                Console.WriteLine(word.ToLower() == reverse.ToLower() ? $"{word} is a palindroom. In reverse its {reverse}" : $"{word} is not a palindroom. in reverse its {reverse}");
        }
        }
    }