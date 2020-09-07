using System;

namespace Task2
{
    public class Converter
    {
        /// <summary>
        /// Converter a non-negative decimal integer to a string containing a binary representation of this value (Own method).
        /// </summary>
        /// <param name="number">Non-negative integer number</param>
        /// <returns>String representation of a number in binary form.</returns>
        public static string DecToBinExclusive(uint number)
        {
            string result = string.Empty;
            uint tmp = 0;

            while(number > 0)
            {
                tmp = number % 2;
                number /= 2;
                result = tmp.ToString() + result;
            }

            return tmp == 0 ? number.ToString() : result;
        }

        /// <summary>
        /// Converter a non-negative decimal integer to a string containing a binary representation of this value (Standard method).
        /// </summary>
        /// <param name="number">Non-negative integer number</param>
        /// <returns>String representation of a number in binary form.</returns>
        public static string DecToBinStandard(uint number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
