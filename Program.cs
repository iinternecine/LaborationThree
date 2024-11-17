using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine()); // Считываем число B
        Console.WriteLine($"You have entered: {b}");
    }
}
