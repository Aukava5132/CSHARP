namespace Lab7;

internal static class GeneratePerson
{
    public static Random random = new Random();
    public static string[] FirstNames = new string[] { " Хенк", "Кера", "Маркус", "Алиса", "Норт" };
    public static string[] LastNames = new string[] { " Камски", "Андерсон", "Сатору", "Кали", "Ньюбон" };
    
    public static string RandFirstNames() => FirstNames[random.Next(FirstNames.Length)];
    public static string RandLastNames() => LastNames[random.Next(LastNames.Length)];  
    public static DateTime RandDate() => new DateTime(random.Next(1950,2000), random.Next(1,12), random.Next(1,28));
    public static Person RandPerson => new Person(RandFirstNames(), RandLastNames(), RandDate());
}
