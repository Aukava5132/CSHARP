using System.Globalization;

namespace Lab7;


class Program
{
    static void Main() //(1 % 11 + 1) = 2 Варiант
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Magazine magazine = GenerateMagazine.RandMagazine();

        Console.WriteLine("Сгенерований журнал:");
        Console.WriteLine(magazine.ToString());
        
        Article newArticle = GenerateArticle.RandArticle();
        Console.WriteLine("\nДодаємо статтю");
        Console.WriteLine(newArticle);
        magazine.Add(newArticle);

        Console.WriteLine("\nОновлений журнал:");
        Console.WriteLine(magazine.ToString());
        
        MagazineFileContainer container = new MagazineFileContainer(magazine);

        string fileName = "magazine_data.txt";
        
        container.Save(fileName);
        Console.WriteLine($"\nДанi збереженi у файл: {fileName}");
        
        MagazineFileContainer loadedContainer = new MagazineFileContainer(new Magazine());
        loadedContainer.Load(fileName);
        Console.WriteLine("\nЗавантажений із файлу журнал:");
        Console.WriteLine(loadedContainer.ToString());
        
        if (loadedContainer.Count > 0)
        {
            Console.WriteLine("\nВидалення першої статтi...");
            loadedContainer.Delete(loadedContainer[0]);

            Console.WriteLine("\nОновлений журнал:");
            Console.WriteLine(loadedContainer.ToString());
        }
        
        Magazine loadedMagazine = (loadedContainer as MagazineFileContainer)?.MagazineInstance;
        
        if (loadedMagazine != null)
        {
            loadedMagazine.SortByRating();
            Console.WriteLine("\nВiдсортований журнал:");
            Console.WriteLine(loadedMagazine.ToString());
        }
    }
}

         