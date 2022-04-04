// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class TrainglePattern
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            int a = 95;
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char) a++);
            }
            Console.WriteLine(" ");
        }
    
    
    }
}