namespace Lab6p2;

public abstract class Person
{
    private string _name;
    private string _lastname;
    private int _age;

    public Person(string name, string lastname, int age)
    {
        Name = name;
        LastName = lastname;
        Age = age;
    }

    public Person()
    {
        
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string LastName
    {
        get => _lastname;
        set => _lastname = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }
    public abstract void Display();
}