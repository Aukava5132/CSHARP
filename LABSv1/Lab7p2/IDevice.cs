namespace Lab7p2;

public interface IDevice
{
    string Name { get; }
    bool HasEngine { get; }
    void ShowInfo();
}