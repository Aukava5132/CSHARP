namespace Lab2p3;

public static class Program
{

    public static void Level1()
    {
        int x = 1;
        int life = 5;
        int input = -1;
        for (int round = 1; round < 4; round++)
        {
            life = 5;
            for (; x != input && life != 0;life--)
            {
                Console.WriteLine($"Раунд {round} / 3 Введiть число вiд 1 до 10, життiв лишилось {life}");
                input = int.TryParse(Console.ReadLine(), out int inp) ? inp : 0;
                if (x != input)
                {
                    Console.WriteLine("Не вiрне число");
                    Console.WriteLine($"input: {input}");
                }
            }
        }
        if (life != 0)
        {
            Console.WriteLine("Ви вгадаи число!");
            Console.WriteLine("[1] - Перейти на другий рiвень [2] - Закiнчити гру i переглянути результати");
            int yesno = int.TryParse(Console.ReadLine(), out int yn) ? yn : 2;
            if (yesno == 1)
            {
                Level2();
            }
            else Console.WriteLine($"Ваш результат: {life * 5} сонечок");
        }
        else
        {
            Console.WriteLine("Ви програли");
        }
    }

    public static void Level2()
    {
        int x = 1;
        int life = 5;
        int input = -1;
        for (int round = 1; round < 4; round++)
        {
            life = 5;
            for (; x != input && life != 0; life--)
            {
                Console.WriteLine($"Раунд {round} / 3 Введiть число вiд 1 до 10, життiв лишилось {life}");
                input = int.TryParse(Console.ReadLine(), out int inp) ? inp : 0;
                if (x != input)
                {
                    Console.WriteLine("Не вiрне число");
                    Console.WriteLine($"input: {input}");
                }
            }
        }
        if (life != 0)
        {
            Console.WriteLine("Ви вгадаи число та пройшли гру!");
            Console.WriteLine($"Ваш результат: {life * 10} сонечок");
        }
        else
        {
            Console.WriteLine("Ви програли");
        }
    }
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Level1();
    }
}