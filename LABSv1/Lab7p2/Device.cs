namespace Lab7p2;

public abstract class Device : IDevice, ICloneable
{
    public string Name { get; protected set; }
    public bool HasEngine { get; protected set; }

    public Device(string name, bool hasEngine)
    {
        Name = name;
        HasEngine = hasEngine;
    }

    public abstract void ShowInfo();

    public abstract object Clone();
}