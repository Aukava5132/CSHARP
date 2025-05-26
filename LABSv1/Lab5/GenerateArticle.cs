namespace Lab5;

internal static class GenerateArticle
{
    public static Random random = new Random();
    public static string[] _names = new string[] { "Новини","Кроссворди","TV Програми","Працевлаштування","Лотереї" };
    
    public static Person RandPerson() => GeneratePerson.RandPerson;
    public static string RandName() => _names[random.Next(_names.Length)];
    public static double RandRaiting() => random.Next(0,10);
    public static Article RandArticle() => new Article(RandPerson(), RandName(),RandRaiting());
}