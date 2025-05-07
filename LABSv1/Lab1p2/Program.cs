namespace Lab1p2;

public static class Program
{
    static bool yPrint = false;
    public static void Cucle(double x, double y, double xmin, double xmax, double value, StreamWriter writer)
    {
        double interval = (xmax - xmin) / value;
        double number = 0;
        for (x = xmin; x <= xmax; x += interval)
        {
            y = (1 - double.Pow(x, 2))/ (1 + double.Pow(x, 4));
            string lineF = ("|-----------------------|");
            string numberF = ($"|      {number} Function       |");
            string valuesF = ($"| X= {(x >= 0 ? " " : "")}{x:F3777} | Y= {(y >= 0 ? " " : "")}{y:F3} |");
            writer.WriteLine(lineF);
            writer.WriteLine(numberF);
            writer.WriteLine(lineF);
            writer.WriteLine(valuesF);
            number ++;
        }
    }

    public static void Print(string student,StreamWriter writer)
    {
        if (!yPrint)
        {
            writer.WriteLine("      Table values");
            yPrint = true;
        }
        else if (yPrint)
        {
            writer.WriteLine("|-----------------------|");
            writer.WriteLine($"The table created by <{student}>");
        }
    }

    static void Main(string[] args)
    {
        double y = -0.176, x = 2, xmin = -3, xmax = 3,value = 8;
        const string student = "Antanevych A. A.";
        using (StreamWriter writer = new StreamWriter("Lab1p2.txt"))
        {
            Print(student,writer);
            Cucle(x,y,xmin,xmax,value,writer);
            Print(student,writer);
            
        }
    }
}