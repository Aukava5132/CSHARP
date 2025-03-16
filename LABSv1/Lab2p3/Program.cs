using System.Security.Cryptography;

namespace Lab2p3;

public static class Program
{

    public static void Level1()
    {
        int x = 0;
        int life = 5;
        int input = -1;
        int perevirka = 0;
        for (int round = 1; round < 4; round++)
        {
            life = 5;
            Random xrandom = new Random();
            x = xrandom.Next(1, 10);
            for (; x != input && life != 0; life--)
            {
                Console.WriteLine($"Раунд {round} / 3 Введiть число вiд 1 до 10, життiв лишилось {life} {x}");
                input = int.TryParse(Console.ReadLine(), out int inp) ? inp : 0;
                if (x != input)
                {
                    Console.WriteLine("Не вiрне число, обмiняти життя на пiдказку [1] Так [2] Нi");
                    perevirka = int.TryParse(Console.ReadLine(), out int per) ? per : 0;
                    if (input < x && perevirka == 1)
                    {
                        Console.WriteLine("Загадане число бiльше вашого");
                        life--;
                    }

                    if (input > x && perevirka == 1)
                    {
                        Console.WriteLine("Загадане число меньше вашого");
                        life--;
                    }
                }
            }
            if (life != 0)
            {
                Console.WriteLine("Ви вгадали число!");
                Console.WriteLine("[1] - Перейти на другий рiвень [2] - Закiнчити гру i переглянути результати");
                int yesno = int.TryParse(Console.ReadLine(), out int yn) ? yn : 2;
                round = 4;
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
    }

    public static void Level2()
    {
        int x = 1;
        int life = 5;
        int input = -1;
        int perevirka = 0;
        for (int round = 1; round < 4; round++)
        {
            life = 5;
            for (; x != input && life != 0; life--)
            {
                Console.WriteLine($"Раунд {round} / 3 Введiть число вiд 1 до 100, життiв лишилось {life}");
                input = int.TryParse(Console.ReadLine(), out int inp) ? inp : 0;
                Random xrandom = new Random(); 
                x = xrandom.Next(10, 100);
                if (x != input)
                {
                    Console.WriteLine("Не вiрне число, обмiняти життя на пiдказку [1] Так [2] Нi");
                    perevirka = int.TryParse(Console.ReadLine(), out int per) ? per : 0;
                    if (input < x && perevirka == 1)
                    {
                        Console.WriteLine("Загадане число бiльше вашого");
                        life--;
                    }

                    if (input > x && perevirka == 1)
                    {
                        Console.WriteLine("Загадане число меньше вашого");
                        life--;
                    }
                }
            }
            if (life != 0)
            {
                Console.WriteLine("Ви вгадаи число та пройшли гру!");
                Console.WriteLine($"Ваш результат: {life * 10} сонечок");
                round = 4;
            }
            else
            {
                Console.WriteLine("Ви програли");
            }
        }
    }
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Level1();
    }
}