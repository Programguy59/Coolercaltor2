using System;

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
            Console.Write("what operation would you like to perform now: ");
            string type = Console.ReadLine();
            if(type = "+")
            {
                Console.WriteLine(plus(num1,num2));
            } else if (type = "-")
            {

             Console.WriteLine(minus(num1,num2));
            } else if (type = "/")
            {

             Console.WriteLine(division(num1,num2));
            } else if (type = "*")
            {
             Console.WriteLine(multiply(num1,num2));

            }
         

        }
        public double plus(double num1, double num2)
        {
            return num1 + num2;
        }
        public double division(double num1, double num2)
        {

            return num1 / num2;
        }
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double minus(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}

