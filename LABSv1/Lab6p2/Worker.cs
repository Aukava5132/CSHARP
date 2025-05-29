namespace Lab6p2;

public class Worker: Person
{
    private int _exp;

    public Worker(string name,string lastname, int age, int exp):base(name,lastname,age)
    {
        Exp = exp;
    }

    public Worker(): base()
    {
        Exp = 0;
    }

    public int Exp
    {
        get => _exp;
        set => _exp = value;
    }

    public override void Display()
    {
        Console.WriteLine($"[Worker] \n Name: {Name} {LastName} \n Age: {Age} years \n Exp: {Exp} years\n");
    }
}