using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp2
{
    internal class bank
    {

     static void checkbalance(string accountid, double amount, double currentbalance)
        {

            if(amount == 0)
            {
                Console.WriteLine("Ignored zero in struction");
                return;
              
            }
            else if(amount < 0 && Math.Abs(amount) > currentbalance)
            {
                Console.WriteLine("Declined insufficent fund");
                return;
                
            }

            else
            {
                double newbalance = currentbalance + amount;
                Console.WriteLine("approved" + newbalance);
                return;


            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your account id");
            string accountid = Console.ReadLine();
            Console.WriteLine("Enter your amount");

            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your  balance");

            double currentbalance = double.Parse(Console.ReadLine());


            checkbalance(accountid, amount, currentbalance);
            
        }
    }
}
