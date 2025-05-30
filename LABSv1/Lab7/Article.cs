namespace Lab7;

public class Article : IComparable<Article>, ICloneable
{
    private Person _person;
    private string _name;
    private int _rating;

    public Article(Person person, string name, int rating)
    {
        _person = person;
        _name = name;
        _rating = rating;
    }

    public Article()
    {
        
    }

    public override string ToString()
    {
        return $"Автор статтi: {Person}. \nНазва статтi {Name}. \nРейтинг статтi: {Rating:F2}";
    }

    public Person Person
    {
        get => _person;
        set => _person = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Rating
    {
        get => _rating;
        set => _rating = value;
    }
    
    public int CompareTo(Article other) {
        return Rating - other.Rating;
    }
    
    public object Clone()
    {
        return new Article
        {
            Person = (Person)this.Person.Clone(),
            Name = this.Name,
            Rating = this.Rating
        };
    }

}