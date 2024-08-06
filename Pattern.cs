using System;

public class Pattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the height");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            
            for (int j = 1; j <= i*2 - 1; j++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
 
        }
        
    }
}