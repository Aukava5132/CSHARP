namespace Lab7p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Registry registry = new Registry();
            
            registry.AddDevice(new Airplane("L-410 Turbolet", 1000, "Поршневий"));
            registry.AddDevice(new HangGlider("Aeros Combat"));
            registry.AddDevice(new Airplane("Airbus A380", 40000, "Реактивний"));
            registry.AddDevice(new HotAirBalloon("SkyFly","Пластик", 300));
            
            Console.WriteLine("\n---  Усі пристрої ---");
            registry.ShowAllDevices();
            
            Console.WriteLine("\n---  З двигунами ---");
            registry.ShowDevicesWithEngine();
            
            Console.WriteLine("\n---  Без двигунів ---");
            registry.ShowDevicesWithoutEngine();
            
            Console.WriteLine("\n---  Сортуємо за ім'ям ---");
            registry.SortByName();
            registry.ShowAllDevices();
            
            Console.WriteLine("\n---  Сортуємо за наявністю двигуна ---");
            registry.SortByEnginePresence();
            registry.ShowAllDevices();
            
            Console.WriteLine("\n---  Клоновані пристрої ---");
            var clones = registry.CloneDevices();
            foreach (var device in clones)
            {
                if (device != null)
                    device.ShowInfo();
            }
        }
    }
}

