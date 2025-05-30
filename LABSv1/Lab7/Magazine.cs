using System.Collections;

namespace Lab7;

public class Magazine : IContainer<Article>, IEnumerable<Article>, IComparable<Magazine>, ICloneable
{
    private string _name;
    private Frequency _frequency;
    private DateTime _date;
    private int _edition;
    private Article[] _articles = new Article[4]; 
    private int _count = 0;
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
        _articles = new Article[articles.Length];
        for (int i = 0; i < articles.Length; i++)
        {
            _articles[i] = articles[i];
        }
        _count = articles.Length;
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
        return $"Назва журналу: {Name}.\nНомер тиражу: {Edition}. \nСереднiй рейтинг: {AverateRaiting}";
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

    public int Edition
    {
        get => _edition;
        set => _edition = value;
    }

    public Article[] Articles
    {
        get
        {
            Article[] result = new Article[_count];
            for (int i = 0; i < _count; i++)
                result[i] = _articles[i];
            return result;
        }
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

    public void AddArticles(Article[] articles)
    {
        foreach (var article in articles)
        {
            AddArticle(article);
        }
    }
    public void AddArticle(Article article)
    {
        if (_count >= _articles.Length)
        {
            Article[] newArray = new Article[_articles.Length * 2];
            for (int i = 0; i < _articles.Length; i++)
                newArray[i] = _articles[i];
            _articles = newArray;
        }

        _articles[_count++] = article;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public IEnumerator<Article> GetEnumerator()
    {
        return ((IEnumerable<Article>)Articles).GetEnumerator();
    }

    public int CompareTo(Magazine other)
    {
        return Edition - other.Edition;
    }

    public object Clone()
    {
        Article[] copiedArticles = new Article[Articles.Length];
        for (int i = 0; i < Articles.Length; i++)
        {
            copiedArticles[i] = (Article)Articles[i].Clone();
        }

        Magazine clone = new Magazine
        {
            Name = this.Name,
            Frequency = this.Frequency,
            Date = this.Date,
            Edition = this.Edition
        };
        clone.AddArticles(copiedArticles);
        return clone;
    }
    
    public int Count => _count;
    
    public Article this[int index]
    {
        get
        {
            if (index >= 0 && index < _count)
                return _articles[index];
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < _count)
                _articles[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }

    public void Add(Article element)
    {
        AddArticle(element);
    }

    public void Delete(Article element)
    {
        int index = -1;
        for (int i = 0; i < _count; i++)
        {
            if (_articles[i].Equals(element))
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            for (int i = index; i < _count - 1; i++)
                _articles[i] = _articles[i + 1];
            _count--;
        }
    }
    
    public void SortByRating()
    {
        for (int i = 0; i < _count - 1; i++)
        {
            int maxIndex = i;
            
            for (int j = i + 1; j < _count; j++)
            {
                if (_articles[j].Rating > _articles[maxIndex].Rating)
                {
                    maxIndex = j;
                }
            }
            
            if (maxIndex != i)
            {
                (_articles[i], _articles[maxIndex]) = (_articles[maxIndex], _articles[i]);
            }
        }
    }
}