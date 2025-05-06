namespace Lab3p2;

class Program
{
    static void Part1(int[,] arr, int n)
    {
        int middle = (arr.GetLength(1) + 1 )/ 2;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] sum = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= arr.GetLength(1) - middle; j++)
            {
                left[i] += arr[i, j];
            }
            for (int j = middle; j < arr.GetLength(1); j++)
            {
                right[i] += arr[i, j];
            }
            sum[i] += left[i] - right[i];
            Console.WriteLine($"{sum[i]}");
        }
    }

    static void Main(string[] args) //(20 + 3 + 1) % 30 = 24
    {
        const int n = 5;
        int[,] arr = new int[n, n]
        {
            {2, 3, 1, 101, 100},
            {1, 1, 2, 100, 100},
            {1, 2, 1, 100, 100},
            {1, 1, 1, 100, 140},
            {1, 1, 1, 100, 100}
        };
        Part1(arr, n);
    }
}