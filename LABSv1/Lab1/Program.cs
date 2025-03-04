namespace Lab1;

public static class Program
{
    static void Main(string[] args)
    {
        double f;
        const double p = 3.14;
        Console.WriteLine("Input x: ");
        double x = double.TryParse(Console.ReadLine(),out double inX) ? inX : 14.26;
        Console.WriteLine("Input y: ");
        double y = double.TryParse(Console.ReadLine(),out double inY) ? inY : -1.22;
        Console.WriteLine("Input z: ");
        double z = double.TryParse(Console.ReadLine(),out double inZ) ? inZ : 3.5 * 10E-2;
        f = (double.Cos(2) * (x - p / 6) / 0.5 + double.Pow(double.Sin(y),2)) * 
            (1 + double.Pow(z , 2) / 3 - double.Pow(z , 2) / 5);
        Console.WriteLine($"Result: {f}");
    }
}