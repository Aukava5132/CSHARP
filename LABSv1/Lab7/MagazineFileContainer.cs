using System.Globalization;

namespace Lab7;

public class MagazineFileContainer : IFileContainer<Article>
{
    private Magazine _magazine;
    private bool _isDataSaved = false;

    public MagazineFileContainer(Magazine magazine)
    {
        _magazine = magazine;
    }

    public int Count => _magazine.Count;

    public Article this[int index]
    {
        get => _magazine[index];
        set => _magazine[index] = value;
    }

    public void Add(Article element)
    {
        _magazine.Add(element);
        _isDataSaved = false;
    }
    public Magazine MagazineInstance => _magazine;

    public void Delete(Article element)
    {
        _magazine.Delete(element);
        _isDataSaved = false;
    }

    public void Save(string fileName)
    {
        using StreamWriter writer = new StreamWriter(fileName);

        writer.WriteLine(_magazine.Name);
        writer.WriteLine(_magazine.Frequency);
        writer.WriteLine(_magazine.Date.ToString("yyyy-MM-dd"));
        writer.WriteLine(_magazine.Edition);

        writer.WriteLine(_magazine.Count);
        foreach (var article in _magazine)
        {
            writer.WriteLine(article.Person.FirstName);
            writer.WriteLine(article.Person.LastName);
            writer.WriteLine(article.Person.BirthYear.ToString("yyyy-MM-dd"));
            writer.WriteLine(article.Name);
            writer.WriteLine(article.Rating);
        }

        _isDataSaved = true;
    }

    public void Load(string fileName)
    {
        using StreamReader reader = new StreamReader(fileName);

        string name = reader.ReadLine();
        Frequency frequency = Enum.Parse<Frequency>(reader.ReadLine());

        DateTime.TryParse(reader.ReadLine(), out DateTime date);

        int edition = int.Parse(reader.ReadLine());

        int articleCount = int.Parse(reader.ReadLine());
        Article[] articles = new Article[articleCount];
        for (int i = 0; i < articleCount; i++)
        {
            string firstName = reader.ReadLine();
            string lastName = reader.ReadLine();
            
            DateTime.TryParse(reader.ReadLine(), out DateTime birthDate);

            string articleName = reader.ReadLine();
            int rating = int.Parse(reader.ReadLine());

            Person author = new Person(firstName, lastName, birthDate);
            articles[i] = new Article(author, articleName, rating);
        }

        _magazine = new Magazine(name, frequency, date, edition, articles);
        _isDataSaved = true;
    }
    public bool IsDataSaved => _isDataSaved;
}
