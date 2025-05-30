namespace Lab8p2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var suitcase = new Suitcase("Червона", "Samsonite", 4.5, 40.0);
            
            suitcase.ItemAdded += item => Console.WriteLine($"Додано об'єкт: {item.Name}");
            
            var items = new SuitcaseItem[] {
                new SuitcaseItem("Футболка", 2.0),
                new SuitcaseItem("Ноутбук", 5.0),
                new SuitcaseItem("Книга", 1.5),
                new SuitcaseItem("Кросівки", 7.0),
                new SuitcaseItem("Секретна цегла", 30.0)
            };

            for (int i = 0; i < items.Length; i++)
            {
                if (suitcase.UsedVolume + items[i].Volume <= suitcase.Capacity)
                {
                    suitcase.AddItem(items[i]);
                }
                else
                {
                    Console.WriteLine($"Не влізло: {items[i].Name}");
                }
            }

            Console.WriteLine();
            suitcase.ShowInfo();
        }
    }
}
