namespace LABSv1;

public static class Program
{
    static void cwArr() 
    {
        const int n = 5;
        int[,] arr = new int[n, n]
        {
            {1, 1, 1, 100, 100},
            {1, 1, 1, 100, 100},
            {1, 1, 1, 100, 100},
            {1, 1, 1, 100, 100},
            {1, 1, 1, 100, 100}
        };
        int middle = (arr.GetLength(1) + 1 )/ 2;
        int left = 0, right = 0;
        
        for (int i = 0; i <= arr.GetLength(1) - middle; i++)
        {
            left += arr[2, i];
            Console.Write(arr[2, i] + " left ");
        }

        for (int i = middle; i < arr.GetLength(1); i++)
        {
            
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    }
}