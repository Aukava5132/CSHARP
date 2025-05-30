namespace Lab8;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Action showTime = () => Console.WriteLine("Поточний час: " + DateTime.Now.ToLongTimeString());
        Action showDate = () => Console.WriteLine("Поточна дата: " + DateTime.Now.ToShortDateString());
        Action showDayOfWeek = () => Console.WriteLine("День тижня: " + DateTime.Now.DayOfWeek);

        showTime();
        showDate();
        showDayOfWeek();

        Console.WriteLine();
        
        Predicate<int> isPrime = (number) =>
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        };

        Predicate<int> isFibonacci = (n) =>
        {
            bool isPerfectSquare(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            return isPerfectSquare(5 * n * n + 4) || isPerfectSquare(5 * n * n - 4);
        };

        int testNumber = 13;
        Console.WriteLine($"Число {testNumber} просте? {isPrime(testNumber)}");
        Console.WriteLine($"Число {testNumber} є числом Фібоначчі? {isFibonacci(testNumber)}");

        Console.WriteLine();
        
        Func<double, double, double, double> triangleArea = (a, b, c) =>
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        };

        Func<double, double, double> rectangleArea = (width, height) => width * height;

        double triangle = triangleArea(3, 4, 5); 
        double rectangle = rectangleArea(5, 8);

        Console.WriteLine("Площа трикутника (3, 4, 5): " + triangle);
        Console.WriteLine("Площа прямокутника (5, 8): " + rectangle);
    }
}