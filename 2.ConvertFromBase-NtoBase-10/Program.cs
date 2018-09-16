﻿using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _2.ConvertFromBase_NtoBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0);

            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
