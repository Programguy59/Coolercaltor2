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
            Console.Write("what operation would you like to perform now, choose + - * or /: ");
            string type = Console.ReadLine();
            if(type == "+")
            {
                Console.WriteLine(Plus(num1,num2));
            } else if (type == "-")
            {
              Console.WriteLine(Minus(num1,num2));
            } else if (type == "/")
            {
             Console.WriteLine(Division(num1,num2));
            } else if (type == "*")
            {
             Console.WriteLine(Multiply(num1,num2));
            }
            else
            {
                //Hvis du skriver noget der ikke er + - * eller /
                Console.WriteLine("Du er dum, start forfra");
            }
         

        }
        static double Plus(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Division(double num1, double num2)
        {

            return num1 / num2;
        }
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}

