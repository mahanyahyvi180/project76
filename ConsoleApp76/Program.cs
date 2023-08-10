using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {

            string secreyword = "giraffe";

            string guess = "";

            while (guess != secreyword)
            {
                Console.Write("Enter guess :");

                guess = Console.ReadLine();
            }
            Console.Write("you win");

            Console.ReadLine();
        }
    }
}
