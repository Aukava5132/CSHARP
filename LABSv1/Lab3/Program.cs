namespace Lab3;

internal class Program
{
    public static int choiceMin(int[] arr)
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
        Console.WriteLine($"{sum}");
        return sum;
    }
    
    public static int choiceMax(int[] arr) 
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
        Console.WriteLine($"{sum}");
        return sum;
    }
    
    static void Main(string[] args)
    {
        int[] arr = {10,9,8,7,6,5,4,3,10};
        int sum = choiceMax(arr);
    }
}
