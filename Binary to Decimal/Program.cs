using System;
using System.Globalization;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetDecimal("11111111"));
        }

        public static int GetDecimal(string binary)
        {
            var result = 0;
            for (int i = binary.Length - 1; i > -1; i--)
            {
                result += CharUnicodeInfo.GetDecimalDigitValue(binary[i]) << i;
            }

            return result;
        }
    }
}
