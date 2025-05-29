namespace Lab6p2;

public class Engineer: Worker
{
    private string _jobTitle;
        
    public Engineer(string name, string lastname, int age, int exp, string jobTitle):base(name,lastname,age,exp)
    {
        JobTitle = jobTitle;
    }
    
    public Engineer():base()
    {
        JobTitle = "";
    }

    public string JobTitle
    {
        get => _jobTitle;
        set => _jobTitle = value;
    }
    
    public override void Display()
    {
        Console.WriteLine($"[Engineer] \n Name: {Name} {LastName} \n Age: {Age} years \n Exp: {Exp} years \n JobTitle: {JobTitle}\n");
    }
}