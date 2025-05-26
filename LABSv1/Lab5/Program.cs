using System.Globalization;

namespace Lab5;


class Program
{
    static public string First(Magazine magazine)
    {
        return "Скорочена iнформацiя: \n" + magazine.ToShortString() +
               "\nЖурнал Weekly? " + magazine.IsFrequency(Frequency.Weekly) +
               "\nЖурнал Montly? " + magazine.IsFrequency(Frequency.Monthly) +
               "\nЖурнал Yearly? " + magazine.IsFrequency(Frequency.Yearly) +
               "\n" + magazine.ToString();
    }
    static public string Second(Magazine magazine)
    {
        Person person2 = new Person("Маркус", "Манфред", new DateTime(1979, 6, 1));
        Article article2 = new Article(person2, "Аватар 2", 4);
        Article article3 = new Article(person2, "Аватар 3", 8);
        Article article4 = new Article(person2, "Аватар 4", 6);
        Article[] allArticles = new Article[] { article2, article3, article4 };
        magazine.AddArticles(allArticles);
        return "\nПовна iнформацiя: \n" + magazine.ToString();
    }
    static public string Third()
    {
        Magazine[] magazines = GenerateMagazine.RandMagazines();
        Array.Sort(magazines, (y, x) => x.AverateRaiting.CompareTo(y.AverateRaiting));
        string topThreeMagazines = "Топ 3 журнали за рейтингом: \n";
        for (int i = 0; i < 3; i++)
        {
            topThreeMagazines += magazines[i].AverateRaiting + " "+ magazines[i].Name + "\n";
        }
        return topThreeMagazines;
    }
    

    static void Main() //(1 % 11 + 1) = 2 Варiант
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Magazine magazine = GenerateMagazine.RandMagazine();
        Console.WriteLine(First(magazine));
        Console.WriteLine(Second(magazine));
        Console.WriteLine(Third());
    }
}

         