using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The result of multiplication: {a * b}");
    }
}
