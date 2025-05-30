namespace Lab8p2;

public class Suitcase
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public double Weight { get; set; }
    public double Capacity { get; set; }

    private SuitcaseItem[] _items = new SuitcaseItem[0];
    private int _itemsCount = 0;

    public event Action<SuitcaseItem> ItemAdded;

    public Suitcase(string color, string brand, double weight, double capacity)
    {
        Color = color;
        Brand = brand;
        Weight = weight;
        Capacity = capacity;
    }

    public double UsedVolume
    {
        get
        {
            double total = 0;
            for (int i = 0; i < _itemsCount; i++)
            {
                total += _items[i].Volume;
            }
            return total;
        }
    }

    public void AddItem(SuitcaseItem item)
    {
        if (UsedVolume + item.Volume > Capacity)
            throw new SuitcaseOverflowException($"Обсяг валізи буде перевищено! Місця залишилось: {Capacity - UsedVolume} л");
        
        Array.Resize(ref _items, _itemsCount + 1);
        _items[_itemsCount] = item;
        _itemsCount++;

        ItemAdded?.Invoke(item);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Валіза: колір - {Color}, бренд - {Brand}, вага - {Weight} кг, обʼєм - {Capacity} л");
        Console.WriteLine($"Заповнено: {UsedVolume} л / {Capacity} л");
        Console.WriteLine("Вміст:");
        for (int i = 0; i < _itemsCount; i++)
        {
            Console.WriteLine(" - " + _items[i]);
        }
    }
}