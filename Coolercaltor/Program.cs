﻿using System;

namespace Coolercaltor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("what operation would you like two perform: ");
            string type = Console.ReadLine();
         

        }
        public double plus(int num1, int num2)
        {
            return num1 + num2;
        }
        public double division(int num1, int num2)
        {

            return num1 / num2;
        }
        public double multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public double minus(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}

