using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine()); // Считываем число A
        Console.WriteLine($"You have entered: {a}");
    }
}
