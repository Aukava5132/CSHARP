namespace Lab1p3;

public static class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double correct = 0;
        Console.WriteLine("Професор ліг спати о 8 годині, а встав о 9 годині. Скільки годин проспав професор?");
        if (Console.ReadLine() == "1") 
        {
            correct++;
        }
        Console.WriteLine("На двох руках десять пальців. Скільки пальців на 10?");
        if (Console.ReadLine() == "50") 
        {
            correct++;
        }
        Console.WriteLine("Скільки цифр у дюжині?");
        if (Console.ReadLine() == "2") 
        {
            correct++;
        }
        Console.WriteLine("Скільки потрібно зробити розпилів, щоб розпиляти колоду на \n12 частин?\n");
        if (Console.ReadLine() == "11") 
        {
            correct++;
        }
        Console.WriteLine("Лікар зробив три уколи в інтервалі 30 хвилин. Скіль1ки часу він витратив?");
        if (Console.ReadLine() == "30") 
        {
            correct++;
        }
        Console.WriteLine("Скільки цифр 9 в інтервалі 1100");
        if (Console.ReadLine() == "1") 
        {
            correct++;
        }
        Console.WriteLine("Пастух мав 30 овець. Усі, окрім однієї, розбіглися. Скільки овець лишилося?");
        if (Console.ReadLine() == "1") 
        {
            correct++;
        }

        switch (correct)
        {
            case 3:
                Console.WriteLine("«Здібності нижче середнього»");
                break;
            case 4:
                Console.WriteLine("«Здібності середні»");
                break;
            case 5:
                Console.WriteLine("«Нормальний»");
                break;
            case 6:
                Console.WriteLine("«Ерудит»");
                break;
            case 7:
                Console.WriteLine("«Геній»");
                break;
            default: 
                Console.WriteLine("Вам треба відпочити!");
                break;
        }
    }
}