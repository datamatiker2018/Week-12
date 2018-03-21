using System;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetHexadecimal(4095));
        }

        public static string GetHexadecimal(int decimalNumber)
        {
            var hexResult = "000";

            var hexPosition = 0;
            var remainder = decimalNumber;
            for (var i = 256; i > 0; i /= 16, hexPosition++)
            {
                var hexNumber = ' ';

                if (remainder < 16)
                {
                    hexNumber = GetHexadecimalNumberRepresentation(remainder);
                    remainder = 0;
                }
                else
                {
                    hexNumber = GetHexadecimalNumberRepresentation((remainder - remainder % i) / i);                  
                    remainder = remainder % i;
                }

                hexResult = hexResult.Remove(hexPosition, 1).Insert(hexPosition, hexNumber.ToString());
            }

            return hexResult;
        }

        public static char GetHexadecimalNumberRepresentation(int number)
        {
            return number < 9 ? number.ToString()[0] : Convert.ToChar(55 + number);
        }
    }
}
