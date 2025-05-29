namespace Lab6p2;

public class Randomizer
{
    public static Random random = new Random();

    public static string RandomName()
    {
        string[] random_name = { "Jhon", "Max", "Stepan" };
        return random_name[random.Next(0, random_name.Length)];
    }

    public static string RandomLastName()
    {
        string[] random_lastname = { "Smitt", "Parker", "Harrison" };
        return random_lastname[random.Next(0, random_lastname.Length)];
    }

    public static int RandomAge()
    {
        int random_age = random.Next(18, 100);
        return random_age;
    }

    public static int RandomExp()
    {
        int random_exp = random.Next(1, 90);
        return random_exp;
    }

    public static string RandomRank()
    {
        string[] random_rank = { "Soilder", "St.Soilder", "Silver" };
        return random_rank[random.Next(0, random_rank.Length)];
    }

    public static string RandomEngineerJob()
    {
        string[] random_EngineerJob = { "Developer", "Tester" };
        return random_EngineerJob[random.Next(0, random_EngineerJob.Length)];
    }

    public static Worker RandWorker() => new Worker(RandomName(), RandomLastName(), RandomAge(), RandomExp());

    public static Soilder RandSoilder() => new Soilder(RandomName(), RandomLastName(), RandomAge(), RandomExp(), RandomRank());

    public static Engineer RandEngineer() => new Engineer(RandomName(), RandomLastName(), RandomAge(), RandomExp(), RandomEngineerJob());
}