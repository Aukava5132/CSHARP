namespace Lab6p2
{
    internal class Program
    {
        static void Main()
        {
            Person[] person =
            {
                Randomizer.RandWorker(),
                Randomizer.RandSoilder(),
                Randomizer.RandEngineer()
            };
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Display();
            }
        }
    }
}