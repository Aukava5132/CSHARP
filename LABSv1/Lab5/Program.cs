namespace Lab5;

class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _dateOfBirth;
    
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        _firstName = firstName;     
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }
    
    public Person()
    {
        _firstName = "Хенк";     
        _lastName = "Андерсон";
        _dateOfBirth = new DateTime(1985, 9, 6);
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }  
    }
    
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    
    public DateTime DateOfBirth
    {
        get => _dateOfBirth; 
        set => _dateOfBirth = value;
    }
    
    public override string ToString()
    {
        return $"Iм`я: {_firstName} {_lastName}, Дата народження: {_dateOfBirth.ToString("dd.MM.yyyy")}";
    }
    
    public string ToShortString()
    {
        return $"{_firstName} {_lastName}";
    }
    
    public int BirthYear
    {
        get => _dateOfBirth.Year;
        set => _dateOfBirth = new DateTime(value);
    }

    static void Main() //(1 % 11 + 1) = 2 Варiант
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Person person = new Person("Нехенк", "Неандерсон", new DateTime(1990, 5, 15));
        Person person = new Person();
        Console.WriteLine(person.BirthYear);
        Console.WriteLine(person.ToString());
    }
}

         