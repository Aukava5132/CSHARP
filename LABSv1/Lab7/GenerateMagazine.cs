namespace Lab7;

internal static class GenerateMagazine
{
    public static Random random = new Random();
    public static string[] Names = new[] { "Forbes", "Новини 24", "Українська Правда", "Всесвіт", "Вітчизна" };
    public static string RandName() => Names[random.Next(Names.Length)];
    public static Frequency RandFrequency() => (Frequency)random.Next(Enum.GetNames(typeof(Frequency)).Length);
    public static DateTime RandDate() => new DateTime(random.Next(2012, 2025), random.Next(1, 12), random.Next(1, 28));
    public static int RandEdition() => random.Next(1, 10);
    
    public static Article[] RandArticles()
    {
        int countArticles = random.Next(1, 3);
        Article[] newArticles = new Article[countArticles];
        for (int i = 0; i < newArticles.Length; i++)
        { 
            newArticles[i] = GenerateArticle.RandArticle();
        }
        return newArticles;
    }
    public static Magazine RandMagazine() => new Magazine(RandName(),RandFrequency(),RandDate(),RandEdition(),RandArticles());

    public static Magazine[] RandMagazines()
    {
        int countMagazines = random.Next(3,10);
        Magazine[] magazines = new Magazine[countMagazines];
        for (int i = 0; i < countMagazines; i++)
        {
            magazines[i] = RandMagazine();
        }
        return magazines;
    }
    
    

}