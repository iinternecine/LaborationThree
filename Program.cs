using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод числа A
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"You have entered: {a}");

        // Ввод числа B
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"You have entered: {b}");

        // Сложение чисел А и В
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The result of addition: {a + b}");

        // Вычитание чисел А и В
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The result of the subtraction: {a - b}");

        // Умножение чисел А и В
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The result of the multiplication: {a * b}");

        // Деление чисел А и В
        Console.WriteLine("Enter a number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The result of the division: {a / b}");
    }
}