namespace Lab7p2;

public class HotAirBalloon : IDevice, ICloneable, IPart
{
    public string Name { get; private set; }
    public bool HasEngine => false;

    public string Material { get; private set; }
    public double Weight { get; private set; }

    public HotAirBalloon(string name, string material, double weight)
    {
        Name = name;
        Material = material;
        Weight = weight;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Повітряна куля: {Name}, двигун: немає, матеріал: {Material}, вага: {Weight} кг");
    }

    public object Clone()
    {
        return new HotAirBalloon(this.Name, this.Material, this.Weight);
    }
}