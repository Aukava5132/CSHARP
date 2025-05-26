namespace Lab6;

internal class Program
{
    static void Main()
    {
        Threeangle one = new Threeangle(9,4,6);
        double[]angles = one.CalculateAngles();
        Console.WriteLine($"{angles[0] + " " + angles[1] + " " + angles[2]}");
    }
}
