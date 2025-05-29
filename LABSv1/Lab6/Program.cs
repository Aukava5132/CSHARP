namespace Lab6;

internal class Program
{
    static void Main()
    {
        var two = new MirrorThreeangle(5,10);
        double s = two.Sthreeangle();
        Console.WriteLine($"{s}");
    }
}