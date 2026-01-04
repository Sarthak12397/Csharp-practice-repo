using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp2
{
    internal class Mainstuff
    {




        static double add(double value1, double value2)
        {
            return value1 + value2; 
        }

        static double subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        static double multiply(double value1, double value2)
        {
            return (value1 * value2);
        }
         static double divided(double value1, double value2)
        {
            return value1 / value2;
        }
        static void Main(String[] args)
        {



            //int results;

            //int Addtwoval(int val1, int val2)
            //{
            //    int result = val1 + val2;
            //    return result;
            //}


            //Console.WriteLine("Enter the number one");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number 2");
            //int num2 = int.Parse(Console.ReadLine());
            //int results = Addtwoval(num1, num2);

            //Console.WriteLine("the result is " + results);


            // Calclator
            double result;

            Console.WriteLine("Enter your first number");

            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your SECOND number");

            double value2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Choose your sign");
            string sign = Console.ReadLine();


            if (sign == "+")
            {
                 result = add(value1, value2);
                Console.WriteLine("Result is " + result);
            }
            else if(sign == "-")
            {
                result = subtract(value1, value2);
                Console.WriteLine("Result is " + result);
            }
            else if( sign == "*")
            {
                result = multiply(value1, value2);
                Console.WriteLine("Result is " + result);
            }
            else if(sign == "/")
            {

                result = divided(value1, value2);
                Console.WriteLine("Result is " + result);
            }
            else
            {
                Console.WriteLine("Cannot be valid number");
            }

        }
    }
}
