namespace Lab7;

internal static class GenerateArticle
{
    public static Random random = new Random();
    public static string[] Names = new string[] { "Новини","Кроссворди","TV Програми","Працевлаштування","Лотереї" };
    public static Person RandPerson() => GeneratePerson.RandPerson;
    public static string RandName() => Names[random.Next(Names.Length)];
    public static int RandRaiting() => random.Next(0,10);
    public static Article RandArticle() => new Article(RandPerson(), RandName(),RandRaiting());
    
}