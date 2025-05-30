namespace Lab9p3;

public class Song
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Composer { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Lyrics { get; set; } = string.Empty;
    public string[] Performers { get; set; } = Array.Empty<string>();


    public override string ToString()
    {
        return $"Назва: {Title}\nАвтор: {Author}\nКомпозитор: {Composer}\nРік: {Year}\n" +
               $"Виконавці: {string.Join(", ", Performers)}\nТекст:\n{Lyrics}\n";
    }
}