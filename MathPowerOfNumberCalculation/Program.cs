using System;

namespace MathPowerOfNumberCalculation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is the base number?");
            int b;
            string baseTextValue = Console.ReadLine();
            b = int.Parse(baseTextValue);

            Console.WriteLine("To the power of?");
            int p;
            string powerTextValue = Console.ReadLine();
            p = int.Parse(powerTextValue);

            Console.WriteLine(Math.Pow(b, p));

            Console.ReadLine();
        }
    }
}
