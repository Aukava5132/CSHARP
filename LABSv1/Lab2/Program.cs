namespace Lab2;

class Program
{
    public static void func()
    {
        for (float a = 1f;a < 1.31f;a += 0.1f)
        {
            Console.WriteLine($"Для значення a= {a:F1}");
            for (float x = -1.5f;x <= 1.51f;x += 0.1f)
            {
                float y = (1f / a) * float.Exp(float.Pow(-x / a, 2f));
                Console.WriteLine($"y= {y:F1}");
            }
        }
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        func();
    }
}