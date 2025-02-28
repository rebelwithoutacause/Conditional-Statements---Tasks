using System;

class Program
{
    static void Main()
    {
        
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        
        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("zero");
            return;  
        }

        
        int negativeCount = 0;

        if (num1 < 0) negativeCount++;
        if (num2 < 0) negativeCount++;
        if (num3 < 0) negativeCount++;

        
        if (negativeCount % 2 != 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }
}
