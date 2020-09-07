using System;
using Task1;

namespace Task1_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the root of the nth power of a number using the Newton method with a given accuracy\n");

            Console.Write("Specified number: ");
            if (!Double.TryParse(Console.ReadLine(), out double number))
                throw new ArgumentOutOfRangeException("number", "Incorrect value");

            Console.Write("Degree of the root: ");
            if (!Int32.TryParse(Console.ReadLine(), out int n))
                throw new ArgumentOutOfRangeException("n", "Incorrect value");

            Console.Write("Specified accuracy: ");
            if (!Double.TryParse(Console.ReadLine().Replace('.', ','), out double epsilon))
                throw new ArgumentOutOfRangeException("epsilon", "Incorrect value");

            OutputResult(number, n, epsilon);
            Console.ReadLine();
        }

        static void OutputResult(double number, int n, double epsilon)
        {
            Console.WriteLine($"\nResult of calculation\n{String.Format(new string('=', 21))}\n" +
                $"Newton method: {CalcRootNewton.Calc(number, n, epsilon)}\n" +
                $"Standard method: {CalcRootNewton.CalcPowMethod(number, n)}");
        }
    }
}
