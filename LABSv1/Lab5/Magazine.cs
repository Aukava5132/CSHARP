namespace Lab5;

public class Magazine
{
    private string _name;
    private Frequency _frequency;
    private DateTime _date;
    private int _edition;
    private Article[] _articles;

    private double ItemsArticleRaiting(Article articleItem)
    {
        return articleItem.Rating;
    }

    public Magazine(string name, Frequency frequency, DateTime date, int edition, Article[] articles)
    {
        _name = name;
        _frequency = frequency;
        _date = date;
        _edition = edition;
        _articles = articles;
    }

    public Magazine()
    {
        
    }

    public override string ToString()
    {
        string allArticles = "";
        for (int i = 0; i < _articles.Length; i++)
        {
            allArticles += "\n" + _articles[i];
        }
        return $"Назва журналу: {_name}. \nПерiодичнiсть журналу: {_frequency}. \nДата виходу журналу: " +
                $"{_date:dd.MM.yyyy}. \nНомер тиражу: {_edition}. \nСписок статей в журналi: {allArticles}";
    }

    public string ToShortString()
    {
        return $"Назва журналу: {_name}.\nНомер тиражу {_edition}. \nСередiй рейтинг {AverateRaiting}";
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Frequency Frequency
    {
        get => _frequency;
        set => _frequency = value;
    }

    public DateTime Date
    {
        get => _date;
        set => _date = value;
    }

    public Article[] Articles
    {
        get => _articles;
        set => _articles = value;
    }

    public double AverateRaiting
    {
        get => _articles.Average(ItemsArticleRaiting);
    }

    public bool IsFrequency(Frequency frequency)
    {
        return _frequency == frequency;
    }

    public void AddArticle(Article article)
    {
        Article[] copyArticle = new Article[_articles.Length + 1];
        for (int i = 0; i < _articles.Length; i++)
        {
            copyArticle[i] = _articles[i];
        }
        copyArticle[_articles.Length] = article;
        _articles = copyArticle;
    }
    
    public void AddArticles(Article [] articles)
    {
        Article[] copyArticle = new Article[_articles.Length + articles.Length + 1];
        for (int i = 0; i < _articles.Length; i++) //Копiя старого масиву
        {
            copyArticle[i] = _articles[i];
        }
        for (int i = 0; i < articles.Length; i++) //Дописуем в кiнець новий
        {
            copyArticle[_articles.Length + i] = articles[i];
        }
        _articles = copyArticle;
    }
}