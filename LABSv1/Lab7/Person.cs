namespace Lab7;

public class Person : IComparable<Person>, ICloneable

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
        return $"Iм`я: {FirstName} {LastName}, Дата народження: {DateOfBirth:dd.MM.yyyy)}";
    }
    
    public string ToShortString()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int BirthYear
    {
        get => _dateOfBirth.Year;
        set => _dateOfBirth = new DateTime(value);
    }
    
    public int CompareTo(Person other) 
    {
        return BirthYear - other.BirthYear;
    }
    
    public object Clone()
    {
        return new Person { FirstName = this.FirstName, LastName = this.LastName, DateOfBirth = this.DateOfBirth };
    }
}