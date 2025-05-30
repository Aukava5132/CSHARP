namespace Lab8p2;

public class SuitcaseItem
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public SuitcaseItem(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }

    public override string ToString() => $"{Name} ({Volume} л)";
}
