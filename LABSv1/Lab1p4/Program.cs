using System.Xml;

namespace Lab1p4;

public static class Program
{
    public static double howmany(double weight)
    {
        double x = 0;
        if (weight > 0 && weight <= 2000)
        {
            if (weight > 1500 && weight <= 2000)
            {
                x = 9;
            }
            else if (weight > 1000 && weight <= 1500)
            {
                x = 7;
            }
            else if (weight > 500 && weight <= 1000)
            {
                x = 4;
            }
            else if (weight <= 500)
            {
                x = 1;
            }
        }
        else
        {
            Console.WriteLine("Полiт неможливий: вага заважка");
            Environment.Exit(0);
        }
        return x;
    }

    public static double ABrange(double AB, double fuel, double xAB, double weight)
    {
        xAB = howmany(weight) * AB;
        if (xAB > 0)
        {
            if (xAB <= fuel)
            {
                Console.WriteLine($"Мiнiмальна кiлькiсть палива з пункту А до пункту B {xAB} лiтрiв");
            }
            else
            {
                Console.WriteLine("Полiт неможливий: не достатньо палива з пункту А до пункту B");
            }
        }
        return xAB;
    }
    public static double BCrange(double BC, double fuel, double xBC, double weight)
    {
        xBC = howmany(weight) * BC;
        if (xBC > 0)
        {
            if (xBC <= fuel)
            {
                Console.WriteLine($"Мiнiмальна кiлькiсть палива з пункту B до пункту C {xBC} лiтрiв");
            }
            else
            {
                Console.WriteLine("Полiт неможливий: не достатньо палива з пункту B до пункту C");
            }
        }
        return xBC;
    }
    public static void ACrange(double AC, double fuel, double xAC, double weight)
    {
        xAC = howmany(weight) * AC;
        if (xAC <= fuel)
        {
            Console.WriteLine($"Мiнiмальна кiлькiсть палива з пункту A до пункту C {xAC} лiтрiв");  
        }
        else 
        {
            Console.WriteLine("Полiт неможливий: не достатньо палива з пункту А до пункту C");  
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string[] lines = File.ReadAllLines("Lab1p4.txt");
        double AC = 0, xAB = 0, xBC = 0, xAC = 0, x = 0;
        double AB = double.Parse(lines[0]);     // вiдстань AB км 
        double BC = double.Parse(lines[1]);     // вiдстань BC км 
        double weight = double.Parse(lines[2]); // маса кг
        double fuel = double.Parse(lines[3]);   // розмiр баку л 
        Console.WriteLine($"Вiдстань з пункру А до пункту B: {AB} км.");
        Console.WriteLine($"Вiдстань з пункру B до пункту C: {BC} км.");
        Console.WriteLine($"Вага вантажу: {weight} кг.");
        Console.WriteLine($"Ємність бака: {fuel} л.");
        ABrange(AB, fuel, xAB, weight);
        BCrange(BC, fuel, xBC, weight);
        AC = AB + BC;
        ACrange(AC, fuel, xAC, weight);
    }
}