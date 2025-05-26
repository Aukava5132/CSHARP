namespace Lab5;

internal static class GeneratePerson
{
    public static Random random = new Random();
    public static string[] _firstNames = new string[] { " Хенк", "Кера", "Маркус", "Алиса", "Норт" };
    public static string[] _lastNames = new string[] { " Камски", "Андерсон", "Сатору", "Кали", "Ньюбон" };
    
    public static string RandFistNames() => _firstNames[random.Next(_firstNames.Length)];
    public static string RandLastNames() => _lastNames[random.Next(_lastNames.Length)];  
    public static DateTime RandDate() => new DateTime(random.Next(1950,2000), random.Next(1,12), random.Next(1,28));
    public static Person RandPerson => new Person(RandFistNames(), RandLastNames(), RandDate());
}
