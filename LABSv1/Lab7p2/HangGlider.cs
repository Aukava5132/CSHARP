namespace Lab7p2;

public class HangGlider : Device
{
    public HangGlider(string name) : base(name, false) { }

    public override void ShowInfo()
    {
        Console.WriteLine($"Дельтаплан: {Name}, без двигуна.");
    }

    public override object Clone()
    {
        return new HangGlider(Name);
    }
}