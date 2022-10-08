
using System;

namespace FirtsTask
{
    class Program
    {
        public Program()
        {

        }
        public static void Main()
        {
            string input = Console.ReadLine();
            var splittedInput = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            int h = Convert.ToInt32(splittedInput[0]); // hours
            int m = Convert.ToInt32(splittedInput[1]); // minutes
            Console.Write(((h != 0) ? 12 - h : h) + " "+ ((m != 0) ? 60 - m : m));
        }
    }
}

