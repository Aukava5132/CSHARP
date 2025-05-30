namespace Lab9p2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть шлях до файлу з текстом: ");
            string textFilePath = Console.ReadLine();

            Console.Write("Введіть шлях до файлу зі словами для цензури: ");
            string censorFilePath = Console.ReadLine();

            if (!File.Exists(textFilePath))
            {
                Console.WriteLine("Файл з текстом не знайдено.");
                return;
            }

            if (!File.Exists(censorFilePath))
            {
                Console.WriteLine("Файл зі словами для цензури не знайдено.");
                return;
            }

            string text = File.ReadAllText(textFilePath);
            string[] badWords = File.ReadAllLines(censorFilePath);

            foreach (var badWord in badWords)
            {
                if (string.IsNullOrWhiteSpace(badWord))
                    continue;

                string stars = new string('*', badWord.Length);
                text = ReplaceCaseInsensitive(text, badWord.Trim(), stars);
            }

            Console.WriteLine("\nВідцензурований текст:\n");
            Console.WriteLine(text);
            
            string outputFilePath = Path.Combine(Path.GetDirectoryName(textFilePath), "censored_output.txt");

            File.WriteAllText(outputFilePath, text);
            Console.WriteLine($"\nРезультат збережено у файл: {outputFilePath}");
        }

        static string ReplaceCaseInsensitive(string text, string oldValue, string newValue)
        {
            int index = 0;
            while ((index = text.IndexOf(oldValue, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                text = text.Remove(index, oldValue.Length).Insert(index, newValue);
                index += newValue.Length;
            }
            return text;
        }
    }
}

