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
        Random random = new Random();
        string[] _names = new string[] { "Новини","Кроссворди","TV Програми","Працевлаштування","Лотереї" };
        _person = new Person();
        _name = _names[random.Next(_names.Length)];
        _rating = random.Next(0,10);
    }

    public override string ToString()
    {
        return $"Автор статтi: {_person}. \nНазва статтi {_name}. \nРейтинг статтi: {_rating}";
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