using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, number, fact; // variables
            Console.WriteLine("Enter the Number"); 
            number = int.Parse(Console.ReadLine()); //input 
            fact = number; 
            for (i = number - 1; i >= 1; i--)  // for loop 
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();

        }
    }
}