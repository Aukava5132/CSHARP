using Microsoft.Win32.SafeHandles;

namespace Lab3;

internal class Program
{

    public static void MyCase(StreamWriter writer)
    {
        Console.WriteLine("[1] Введення даних з файлу\n[2] Введення даних самостiйно\n[Будь яке число] Данi сгенерованi випадково");
        int choice = int.TryParse(Console.ReadLine(),out int choi) ? choi : 0;
        int[] arr;
        switch (choice)
        {
            case 1:
                arr = MyCase1();
                break;
            case 2:
                arr = MyCase2();
                break;
            default:
                arr = MyDefault();
                break;
        }
        int sum = ChoiceMax(arr);
        Console.WriteLine($"Добуток найбiльших елементiв = {sum}");
        writer.WriteLine($"Добуток найменших елементiв = {sum}");
        sum = ChoiceMin(arr);
        Console.WriteLine($"Добуток найбiльших елементiв = {sum}");
        writer.WriteLine($"Добуток найменших елементiв = {sum}");
        Console.WriteLine("Збережено в Lab3result.txt");
    }

    public static int[] MyCase1()
    {
        string[] txt = File.ReadAllLines("Lab3.txt");
        int size = int.Parse(txt[0]);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(txt[i + 1]);
        }
        return arr;
    }

    public static int[] MyCase2()
    {
        Console.Write("Введіть розмір масиву:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
        return arr;
    }

    public static int[] MyDefault()
    {
        Random sizerandom = new Random(); 
        int size = sizerandom.Next(6, 15);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = sizerandom.Next(1, 100);
        }
        return arr;
    }

    public static int ChoiceMin(int[] arr)
    {
        int sum = 1;
        int mincount = 3;
        int[] skip = {int.MaxValue, int.MaxValue, int.MaxValue};
        int min;
        for (int j = 0; j < mincount; j++)  //Кiлькiсть мiн елементiв
        {
            min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)    //Розмiр масиву
            {
                if (i == skip[0] || i == skip[1] || i == skip[2])   //Тригер
                {
                    continue;
                }
                if (arr[i] <= min)  //Умова
                {
                    min = arr[i];
                    skip[j] = i;
                }
            }
            sum *= min;
        }
        return sum;
    }
    
    public static int ChoiceMax(int[] arr) 
    {
        int sum = 1;
        int mincount = 3;
        int[] skip = {int.MaxValue, int.MaxValue, int.MaxValue};
        int max;
        for (int j = 0; j < mincount; j++)  //Кiлькiсть мiн елементiв
        {
            max = 1;
            for (int i = 0; i < arr.Length; i++)    //Розмiр масиву
            {
                if (i == skip[0] || i == skip[1] || i == skip[2])   //Тригер
                {
                    continue;
                }
                if (arr[i] >= max)
                {
                    max = arr[i];
                    skip[j] = i;
                }
            }
            sum *= max;
        }
        return sum;
    }
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        using (StreamWriter writer = new StreamWriter("Lab3result.txt"))
        {
            MyCase(writer);
        }
    }
}
