namespace Lab6;

internal class Program
{
    static void Main() //1 % 19 + 1 = 2
    {
        var two = new MirrorThreeangle(5,10);
        double s = two.Sthreeangle();
        Console.WriteLine($"{s}");
    }
}