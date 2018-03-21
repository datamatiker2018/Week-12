using System;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetBinary(255));
        }

        public static string GetBinary(int decimalNumber)
        {
            var binaryReprensentation = "00000000";

            var remainder = decimalNumber;
            var binaryPosition = 0;
            for (var divider = 128; divider > 0; divider = divider / 2, binaryPosition++)
            {
                if (remainder % divider != remainder)
                {
                    remainder = remainder % divider;
                    binaryReprensentation = binaryReprensentation.Remove(binaryPosition, 1).Insert(binaryPosition, "1");
                }
            }

            return binaryReprensentation;
        }
    }
}
