namespace Lab5;

public class Article
{
    private Person _person;
    private string _name;
    private double _rating;

    public Article(Person person, string name, double rating)
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
        return $"Автор статтi: {Person}. \nНазва статтi {Name}. \nРейтинг статтi: {Rating}";
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

    public double Rating
    {
        get => _rating;
        set => _rating = value;
    }
}