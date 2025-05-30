namespace Lab10;

using System.Text.Json; 
using System.Text.Encodings.Web;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new Student[]
        {
            new Student { FullName = "Іваненко Петро Іванович", GroupNumber = "КН-101", Grades = new[] {9, 8, 10, 7, 9} },
            new Student { FullName = "Петренко Iван Миколайович", GroupNumber = "КН-102", Grades = new[] {7, 6, 7, 8, 7} },
            new Student { FullName = "Фiлоненко Артем Петрович", GroupNumber = "КН-101", Grades = new[] {10, 9, 9, 10, 10} }
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping 
        };

        string json = JsonSerializer.Serialize(students, options);

        File.WriteAllText("students.json", json);

        Console.WriteLine(json); 
    }
}