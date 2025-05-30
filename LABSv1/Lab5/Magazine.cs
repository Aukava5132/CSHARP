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
        for (int i = 0; i < Articles.Length; i++)
        {
            allArticles += "\n" + Articles[i];
        }
        return $"Назва журналу: {Name}. \nПерiодичнiсть журналу: {Frequency}. \nДата виходу журналу: " +
                $"{Date:dd.MM.yyyy}. \nНомер тиражу: {Edition}. \nСписок статей в журналi: {allArticles}";
    }

    public string ToShortString()
    {
        return $"Назва журналу: {Name}.\nНомер тиражу {Edition}. \nСередiй рейтинг {AverateRaiting}";
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

    public int Edition
    {
        get => _edition;
        set => _edition = value;
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
        get
        {
            if (Articles == null || Articles.Length == 0)
                return 0;

            double sum = 0;
            for (int i = 0; i < Articles.Length; i++)
                sum += Articles[i].Rating;

            return sum / Articles.Length;
        }
    }


    public bool IsFrequency(Frequency frequency)
    {
        return _frequency == frequency;
    }

    public void AddArticle(Article article)
    {
        Article[] copyArticle = new Article[Articles.Length + 1];
        for (int i = 0; i < Articles.Length; i++)
        {
            copyArticle[i] = Articles[i];
        }
        copyArticle[Articles.Length] = article;
        Articles = copyArticle;
    }
    
    public void AddArticles(Article [] articles)
    {
        Article[] copyArticle = new Article[Articles.Length + articles.Length + 1];
        for (int i = 0; i < Articles.Length; i++) //Копiя старого масиву
        {
            copyArticle[i] = Articles[i];
        }
        for (int i = 0; i < articles.Length; i++) //Дописуем в кiнець новий
        {
            copyArticle[Articles.Length + i] = articles[i];
        }
        Articles = copyArticle;
    }
}