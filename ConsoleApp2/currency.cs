using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class currency
    {
        static double[] rates = { 1.0, 0.93, 1.45, 145.0 };


        static int getcurrency(string currency)
        {
            string[] currencies = { "eur", "usd", "aud", "npr" };

            for (int i = 0; i < currencies.Length; i++)
            {
                if(currencies[i] == currency)
                {
                    return i;
                }
               
            }
            return -1;
        }



        static double conversion(double amount, int start, int end)
        {
            double amountvalues = amount / rates[start];
            return amountvalues * rates[end];
        }





        static void Main(string[] args)
        {


            Console.WriteLine("Enter your amount:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your source currency:");
            string fromCurrency = Console.ReadLine();

            Console.WriteLine("Enter your target currency:");
            string toCurrency = Console.ReadLine();

            int startIndex = getcurrency(fromCurrency);
            int endIndex = getcurrency(toCurrency);

            if (startIndex == -1 || endIndex == -1)
            {
                Console.WriteLine("Invalid currency.");
                return;
            }

            double result = conversion(amount, startIndex, endIndex);
            Console.WriteLine($"Converted amount: {result}");

        }


    }
}
