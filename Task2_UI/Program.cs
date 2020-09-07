using System;
using Task2;

namespace Task2_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter a non-negative decimal integer to a string containing a binary representation of this value\n");

            while (true)
            {
                Console.Write("Decimal number: ");
                if (!UInt32.TryParse(Console.ReadLine(), out uint number)) return;

                string ownMethod = Converter.DecToBinExclusive(number);
                Console.WriteLine($"{string.Format(new string('=', ownMethod.Length + 12))}\n" +
                    $"Own method: {ownMethod}\n" +
                    $"Std method: {Converter.DecToBinStandard(number)}\n");
            }
        }
    }
}
