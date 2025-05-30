namespace Lab8p3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] numbers = { 7, 14, -3, 21, 0, 5, 1, 49, -7, 100, 256 };
        
        Func<int[], int> countDivBySeven = arr =>
        {
            int count = 0;
            foreach (int n in arr)
            {
                if (n % 7 == 0)
                    count++;
            }

            return count;
        };
        Console.WriteLine("Кратних 7: " + countDivBySeven(numbers));
        
        Func<int[], int> countPositive = arr =>
        {
            int count = 0;
            foreach (int n in arr)
            {
                if (n > 0)
                    count++;
            }

            return count;
        };
        Console.WriteLine("Позитивних чисел: " + countPositive(numbers));
        
        Predicate<DateTime> isProgrammerDay = date => date.DayOfYear == 256;
        DateTime testDate = new DateTime(2025, 9, 13);
        Console.WriteLine($"{testDate.ToShortDateString()} — день програміста? {isProgrammerDay(testDate)}");
        
        Func<string, string, bool> containsWord = (text, word) =>
        {
            return text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0;
        };

        string textSample = "Це простий приклад для перевірки пошуку слова в тексті.";
        string wordToFind = "приклад";

        Console.WriteLine($"Чи містить текст слово '{wordToFind}'? {containsWord(textSample, wordToFind)}");
    }
}