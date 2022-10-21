using System;
class World
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your rows number: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int s = 0; s < rows - i; s++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
    
}