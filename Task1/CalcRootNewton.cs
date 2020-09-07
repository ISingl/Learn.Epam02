using System;

namespace Task1
{
    public class CalcRootNewton
    {
        /// <summary>
        /// Calculating the root of the nth power of a number using the Newton method with a given accuracy.
        /// </summary>
        /// <param name="number">Specified number</param>
        /// <param name="n">Degree of the root</param>
        /// <param name="epsilon">Specified accuracy</param>
        /// <returns>number^(1/n)</returns>
        public static double Calc(double number, int n, double epsilon)
        {
            if (n < 1) return Double.NaN;
            if (number < 0) return Double.NaN;
            if (epsilon >= 1 || epsilon <= 0) epsilon = 0.00001;

            double result = number;
            double prevValue = 0;

            while(Math.Abs(prevValue - result) >= epsilon)
            {
                prevValue = result;
                result = (1.0d / n) * ((n - 1) * result + number / Math.Pow(result, n - 1));
            }

            return result;
        }

        /// <summary>
        /// Calculating the root of the nth power of a number using the standard method.
        /// </summary>
        /// <param name="number">Specified number</param>
        /// <param name="n">Degree of the root</param>
        /// <returns>number^(1/n)</returns>
        public static double CalcPowMethod(double number, int n)
        {
            return Math.Pow(number, (1.0d / n));
        }
    }
}
