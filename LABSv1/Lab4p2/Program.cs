using System.Text.RegularExpressions;

namespace Lab4p2;

class Program
{
    public static string Choise()
    {
        Console.WriteLine("[1] Введення даних з файлу\n[2] Введення даних самостiйно\n");
        int choice = int.TryParse(Console.ReadLine(), out int choi) ? choi : 0;
        string text;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Введення даних було проведено з файлу");
                text = File.ReadAllText("Lab4p2.txt");
                break;
            default:
                Console.Write("Введiть слова через пробiл");
                text = Console.ReadLine();
                break;
        }
        return text;
    }

    public static void Task(StreamWriter writer)
    {
        string a = Choise();
        string[] count = Regex.Split(a, "[ ]+");
        string text = new string("");
        int size = count.Length;
        foreach (string item in count)
        {
            if (item[item.Length - 1] == item[0])
            {
                text += " " + item;
            }
        }
        Console.WriteLine("Кiлькiсть слiв: [" + size + "] Спiвпадiння: ");
        writer.WriteLine("Кiлькiсть слiв: [" + size + "] Спiвпадiння: ");
        Console.WriteLine(text.Trim());
        writer.WriteLine(text.Trim());
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        using (StreamWriter writer = new StreamWriter("Lab4p2result.txt"))
        {
            Task(writer);
        }
    }
}