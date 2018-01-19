using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binarynumbers = { 1, 1, 1, 1 };
            int result = binaryArrayToNumber(binarynumbers);

            Console.Write(result);
            Console.ReadLine();
        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int number = 0;
            Array.Reverse(BinaryArray);


            for (int i = 0; i < BinaryArray.Length; i++)
                number += (int)(BinaryArray[i] * Math.Pow(2, i));

            return number;
        }
    }
}
