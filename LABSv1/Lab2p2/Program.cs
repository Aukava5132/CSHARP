namespace Lab2p2;

public static class Program
{
    public static void func()
    {
        float x = -0.84f;
        float y = float.Sqrt(x + 1);
        Console.WriteLine($"Значення Y={y}");
        for (int j = 0; j < 3; j++)
        {
            float S = 1 + x / 2;
            float up = x, up2 = 1;
            float down = 2, down2 = 2;
            Console.WriteLine($"При значеннi X={x}");
            for (int i = 0; S > float.Pow(10, -6); i++)
            {
                Console.WriteLine($"    S= {float.Sqrt(S)}");
                up *= up2 * x;
                up2 += 2;
                down2 += 2;
                down *= down2;
                if (i % 2 == 0)
                {
                    S -= up / down;
                }
                else
                {
                    S += up / down;
                }
            }
            if (j % 2 == 0)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }
        }
    }

static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        func();
    }
}