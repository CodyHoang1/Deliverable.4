/*
Author: Cody Hoang
Date: 2/9/23
Comments: Deliverable 4 
*/



using System;

namespace Deliverable__4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 25)
            {
                int[] fibonacci = new int[input];

                // Initialize fibonacci series 
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {

                    if (i >= 2)
                    {
                        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("Fibonacci number");
                Console.WriteLine("");
                foreach (int number in fibonacci)
                {
                    Console.WriteLine(number);
                }


            }
        }
    }
}