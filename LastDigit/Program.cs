﻿using System;

namespace LastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            LastNume(number);

        }
        static void LastNume(string num)
        {

            char lastDigit = num[num.Length - 1];

            switch (lastDigit)
            {

                case '0':
                    Console.WriteLine("zero");
                    break;
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("fife");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                default:

                    break;


            }
        }
    }
}