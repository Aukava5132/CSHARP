namespace Lab7p2;

public class Airplane : Device, IEngine
{
    public int Power { get; private set; }
    public string EngineType { get; private set; }

    public Airplane(string name, int power, string engineType)
        : base(name, true)
    {
        Power = power;
        EngineType = engineType;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Лiтак: {Name}, двигун: {EngineType} {Power} к.с.");
    }

    public override object Clone()
    {
        return new Airplane(Name, Power, EngineType);
    }
}