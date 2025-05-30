namespace Lab9;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть шлях до файлу: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("Файл не знайдено.");
            return;
        }

        string text = File.ReadAllText(path);

        int sentenceCount = CountSentences(text);
        int upperCount = 0;
        int lowerCount = 0;
        int vowelsCount = 0;
        int consonantsCount = 0;
        int digitsCount = 0;

        string vowels = "аеєиіїоуюяАЕЄИІЇОУЮЯ"; 

        foreach (char c in text)
        {
            if (char.IsUpper(c)) upperCount++;
            if (char.IsLower(c)) lowerCount++;
            if (char.IsDigit(c)) digitsCount++;

            if (vowels.IndexOf(c) >= 0) vowelsCount++;
            else if (char.IsLetter(c) && vowels.IndexOf(char.ToLower(c)) == -1 && char.IsLetter(c))
                consonantsCount++;
        }

        Console.WriteLine($"Кількість речень: {sentenceCount}");
        Console.WriteLine($"Кількість великих літер: {upperCount}");
        Console.WriteLine($"Кількість маленьких літер: {lowerCount}");
        Console.WriteLine($"Кількість голосних літер: {vowelsCount}");
        Console.WriteLine($"Кількість приголосних літер: {consonantsCount}");
        Console.WriteLine($"Кількість цифр: {digitsCount}");
    }

    static int CountSentences(string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            if (c == '.' || c == '!' || c == '?')
                count++;
        }

        return count;
    }
}