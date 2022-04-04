// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class TrainglePattern
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            int A = 65;
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)A++);
            }
            Console.WriteLine(" ");
        }
    
    
    }
}