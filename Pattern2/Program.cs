// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Pattern2
{
    public static void Main(String[] args)
    {
        int a = 17;
        int count = 0;
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                count++;
            }
        }
            if (count == 2)
            {
                Console.WriteLine("Given Number is Prime number");
            }

            else
            {
                Console.WriteLine("Given number is not prime");
            }
    }

        

    }

