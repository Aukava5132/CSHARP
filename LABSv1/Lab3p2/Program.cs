namespace Lab3p2;

class Program
{
    static void Part1(int[,] arr, int n)
    {
        int middle = (arr.GetLength(1) + 1) / 2;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] sum = new int[n];
        for (int i = 0; i < n; i++)
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
            Console.WriteLine($"{sum[i]}");
        }
    }

    static void Part2(int[,] arr, int n) 
    {
        int[] max = new int[n];
        int[,] arrSorted = new int[n,n]; 
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
        for (int i = 0; i < arr.GetLength(1); i++)  // Вивiд
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arrSorted[i, j] + " Sorted ");
            }
            Console.WriteLine(" ");
        }
    }
    

static void Main(string[] args) //(20 + 3 + 1) % 30 = 24
    {
        const int n = 5;
        int[,] arr = new int[n, n]
        {
            {2, 3, 1, 101, 100},
            {1, 1, 2, 130, 100},
            {1, 9999, 1, 100, 160},
            {1, 1, 1, 100, 140},
            {1, 1, 1, 100, 100}
        };
        Part2(arr, n);
    }
}