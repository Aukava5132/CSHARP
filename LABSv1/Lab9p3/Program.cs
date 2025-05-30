namespace Lab9p3;

internal class Program
{
    static void AddSong(SongCollection collection)
    {
        Song s = new();

        Console.Write("Назва пісні: ");
        s.Title = Console.ReadLine();

        Console.Write("ПІБ автора: ");
        s.Author = Console.ReadLine();

        Console.Write("Композитор: ");
        s.Composer = Console.ReadLine();

        Console.Write("Рік написання: ");
        int.TryParse(Console.ReadLine(), out int year);
        s.Year = year;

        Console.WriteLine("Текст пісні:");
        s.Lyrics = Console.ReadLine();

        Console.Write("Введіть виконавців через кому: ");
        s.Performers = Console.ReadLine()!.Split(',').Select(p => p.Trim()).ToArray();
        if (collection.AddSong(s))
            Console.WriteLine("Пісня додана.");
        else
            Console.WriteLine("Місце у колекції закінчилось.");
    }

    static void RemoveSong(SongCollection collection)
    {
        Console.Write("Введіть назву пісні для видалення: ");
        string title = Console.ReadLine();

        if (collection.RemoveSong(title))
            Console.WriteLine("Пісня видалена.");
        else
            Console.WriteLine("Пісня не знайдена.");
    }

    static void UpdateSong(SongCollection collection)
    {
        Console.Write("Введіть назву пісні для зміни: ");
        string title = Console.ReadLine();

        var found = collection.FindByTitle(title);
        if (found.Length == 0)
        {
            Console.WriteLine("Пісня не знайдена.");
            return;
        }

        Console.WriteLine("Введіть нові дані:");

        Song s = new();

        Console.Write("Назва пісні: ");
        s.Title = Console.ReadLine();

        Console.Write("ПІБ автора: ");
        s.Author = Console.ReadLine();

        Console.Write("Композитор: ");
        s.Composer = Console.ReadLine();

        Console.Write("Рік написання: ");
        int.TryParse(Console.ReadLine(), out int year);
        s.Year = year;

        Console.WriteLine("Текст пісні:");
        s.Lyrics = Console.ReadLine();

        Console.Write("Введіть виконавців через кому: ");
        s.Performers = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
        
        if (collection.UpdateSong(title, s))
            Console.WriteLine("Пісня оновлена.");
        else
            Console.WriteLine("Щось пішло не так.");
    }

    static void SearchByTitle(SongCollection collection)
    {
        Console.Write("Введіть назву або її частину для пошуку: ");
        string title = Console.ReadLine();

        var found = collection.FindByTitle(title);
        if (found.Length == 0)
        {
            Console.WriteLine("Пісні не знайдено.");
            return;
        }

        foreach (var s in found)
        {
            Console.WriteLine(s);
            Console.WriteLine(new string('-', 30));
        }
    }

    static void SearchByPerformer(SongCollection collection)
    {
        Console.Write("Введіть ім'я виконавця: ");
        string performer = Console.ReadLine();

        var found = collection.FindByPerformer(performer);
        if (found.Length == 0)
        {
            Console.WriteLine("Пісні не знайдено.");
            return;
        }

        foreach (var s in found)
        {
            Console.WriteLine(s);
            Console.WriteLine(new string('-', 30));
        }
    }

    static void SaveToFile(SongCollection collection)
    {
        Console.Write("Введіть шлях до файлу для збереження: ");
        string path = Console.ReadLine();

        collection.SaveToFile(path);
        Console.WriteLine("Збережено.");
    }

    static void LoadFromFile(SongCollection collection)
    {
        Console.Write("Введіть шлях до файлу для завантаження: ");
        string path = Console.ReadLine();

        collection.LoadFromFile(path);
        Console.WriteLine("Завантажено.");
    }
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        SongCollection collection = new SongCollection(100); 
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 - Додати пісню");
            Console.WriteLine("2 - Видалити пісню");
            Console.WriteLine("3 - Змінити пісню");
            Console.WriteLine("4 - Пошук за назвою");
            Console.WriteLine("5 - Пошук за виконавцем");
            Console.WriteLine("6 - Показати всі пісні");
            Console.WriteLine("7 - Зберегти у файл");
            Console.WriteLine("8 - Завантажити з файлу");
            Console.WriteLine("9 - Вийти");
            Console.Write("Оберіть дію: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddSong(collection); break;
                case "2": RemoveSong(collection); break;
                case "3": UpdateSong(collection); break;
                case "4": SearchByTitle(collection); break;
                case "5": SearchByPerformer(collection); break;
                case "6": collection.ShowAll(); break;
                case "7": SaveToFile(collection); break;
                case "8": LoadFromFile(collection); break;
                case "9": return;
                default: Console.WriteLine("Невірний вибір."); break;
            }
        }
    }
}