using System;

namespace Greadingif
{
    class Program
    {
        static void Main(string[] args)
        {
            // prilozenie prosit polzovatelja vvesi rezultat ego ekzsmena
            // rezultat ekzamena eto odna bukva ot A do F
            // A - Outstanding
            // B - Superior
            // C - Good
            // D - Satisfactory
            // E - Low Pass
            // F - Failure

            Console.WriteLine("Enter your exam results:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userInput == 'A')
            {
                Console.WriteLine("Outstanding");
            }
            if (userInput == 'B')
            {
                Console.WriteLine("Superior");
            }
            if (userInput == 'C')
            {
                Console.WriteLine("Good");
            }
            if (userInput == 'D')
            {
                Console.WriteLine("Satisfactory");

            }
            if (userInput == 'E')
            {
                Console.WriteLine("Low Pass");
            }
            if (userInput == 'F')
            {
                Console.WriteLine("Failure");
            }
        }



    }
}
