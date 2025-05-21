namespace Lab3p2;

class Program
{
    public static void MyCase(StreamWriter writer)
    {
        Console.WriteLine("[1] Введення даних з файлу\n[2] Введення даних самостiйно\n[Будь яке число] Данi сгенерованi випадково");
        int choice = int.TryParse(Console.ReadLine(),out int choi) ? choi : 0;
        int[,] arr;
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
        int[] part1 = Part1(arr);   
        Console.Write("Рiзницi мiж кожними сумами першої та другими половинами масивiв: ");
        writer.Write("Рiзницi мiж кожними сумами першої та другими половинами масивiв: ");
        for (int i = 0; i < part1.Length; i++)
        { 
            Console.Write(part1[i] + " ");
            writer.Write(part1[i] + " ");
        }
        Console.WriteLine();
        writer.WriteLine();
        int[] part2 = Part2(arr); 
        Console.Write("Максимальний елемент кожного масиву: ");
        writer.Write("Максимальний елемент кожного масиву: ");
        for (int i = 0; i < part2.Length; i++)
        { 
            Console.Write(part2[i] + " ");
            writer.Write(part2[i] + " ");
        }
        Console.WriteLine();
        writer.WriteLine();
        int[,] part3 = Part3(arr);
        Console.WriteLine("Впорядкованi масиви: ");
        writer.WriteLine("Впорядкованi масиви: ");
        for (int i = 0; i < arr.GetLength(1); i++) 
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(part3[i, j] + " ");
                writer.Write(part3[i, j] + " ");
            }
            Console.WriteLine(" ");
            writer.WriteLine(" ");
        }
        Console.WriteLine("Збережено в Lab3p2result.txt");
    }
    public static int[,] MyCase1()
    {
        string[] txt = File.ReadAllLines("Lab3p2.txt");
        int size = txt.Length;
        int[,] arr = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            string[] parts = txt[i].Split(' ');
            for (int j = 0; j < size; j++)
            {
                arr[i, j] = int.Parse(parts[j]);
            }
        }
        return arr;
    }
    public static int[,] MyCase2()
    {
        Console.Write("Введіть кiлькiсть та розмiр масивiв:");
        int size = int.Parse(Console.ReadLine());
        int[,] arr = new int[size, size];
        for (int j = 0;j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть [{i + 1}] елемент [{j + 1}] масиву:");
                arr[j,i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        return arr;
    }
    public static int[,] MyDefault()
    {
        Random sizerandom = new Random(); 
        int size = sizerandom.Next(6, 15);
        int randomnumber;
        int[,] arr = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                 randomnumber = sizerandom.Next(1, 10);
                 arr[i, j] = randomnumber;
            }
        }
        return arr;
    }
    public static int[] Part1(int[,] arr)
    {
        int middle = (arr.GetLength(1) + 1) / 2;
        int[] left = new int[arr.GetLength(1)];
        int[] right = new int[arr.GetLength(1)];
        int[] sum = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j <= arr.GetLength(1) - middle; j++)    //Лiва частина
            {
                left[i] += arr[i, j];
            }

            for (int j = middle; j < arr.GetLength(1); j++) //Права частина
            {
                right[i] += arr[i, j];
            }
            sum[i] += left[i] - right[i];
        }
        return sum;
    }

    static int[] Part2(int[,] arr)
    {
        int[] max = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++) 
        {
            for (int j = 0; j < arr.GetLength(1); j++)  //Пошук максимального елементу кожного ряду
            {
                if (arr[i, j] >= max[i])
                {
                    max[i] = arr[i, j];
                }
            }
        }
        return max;
    }

    static int [,] Part3(int[,] arr) 
    {
        int[] max = new int[arr.GetLength(1)];
        int[,] arrSorted = new int[arr.GetLength(1),arr.GetLength(1)]; 
        for (int i = 0; i < arr.GetLength(0); i++) 
        {
            int[] arrParts = new int[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++)  //Роздiлення двовимiрного масиву на тимчасовий одновимiрний
            {
                arrParts[j] = arr[i, j];
            }
            Array.Sort(arrParts);   
            for (int j = 0; j < arr.GetLength(1); j++)  //Збираэмо в iнший двовимiрний масив
            {
                arrSorted[i, j] = arrParts[j];
            }
        }
        return arrSorted;
    }
    

static void Main() //(20 + 3 + 1) % 30 = 24
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        using (StreamWriter writer = new StreamWriter("Lab3p2result.txt"))
        {
            MyCase(writer);
        }
    }
}