using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double y = Math.Pow(CalculateP(x), 2) + Math.Pow(CalculateT(x, a), 4);
        Console.WriteLine($"Результат: y = {y}");
        Console.ReadKey();
    }
    static double CalculateT(double x, double a)
    {
        double t = Math.Pow(x + Math.Pow(a, 2), 1.0 / 3.0); 
        return t;
    }
    static double CalculateP(double x)
    {
        double p = Math.Pow(x, 2) - Math.Sqrt(Math.Abs(x));
        return p;
    }
}


