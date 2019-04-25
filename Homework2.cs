using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            byte a = 0;
            byte b = 0;
            bool repeat = true;
            while (repeat)
            {
                do
                {
                    Console.Write("Enter Length = ");
                }
                while (!byte.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.Write("Enter Width = ");
                }
                while (!byte.TryParse(Console.ReadLine(), out b));
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Error, try again? Y/N");
                    var ki = Console.ReadKey(true);
                    if (ki.Key != ConsoleKey.Y)
                        repeat = false;
                    continue;
                }
                Console.WriteLine("Length: {0}, Width: {1}, Square: {2}", a, b, a * b);
                repeat = false;
                Console.ReadKey();
            }
        }
    }
}