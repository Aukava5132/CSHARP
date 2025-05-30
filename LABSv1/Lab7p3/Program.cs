namespace Lab7p3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string original = "ПРИВІТ УКРАЇНО!";

            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            Console.WriteLine("=== Оригінал ===");
            Console.WriteLine(original);

            Console.WriteLine("\n=== ACipher (зсув на 1) ===");
            string aEncoded = aCipher.Encode(original);
            Console.WriteLine("Зашифровано: " + aEncoded);
            Console.WriteLine("Розшифровано: " + aCipher.Decode(aEncoded));

            Console.WriteLine("\n=== BCipher (дзеркальний шифр) ===");
            string bEncoded = bCipher.Encode(original);
            Console.WriteLine("Зашифровано: " + bEncoded);
            Console.WriteLine("Розшифровано: " + bCipher.Decode(bEncoded));
        }
    }
}

