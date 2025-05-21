using System.Text.RegularExpressions;

namespace Lab4;

class Program
{
    public static void Print(bool result)
    {
        string prt;
        if (result)
        {
            prt = "Correct";
        }
        else
        {
            prt = "Not correct";
        }
        Console.WriteLine(prt);
    }

    public static void Task()
    {
        Console.WriteLine("Enter task [1] [2]");
        int choise = int.TryParse(Console.ReadLine(),out int correct)? correct : 0;
        switch (choise)
        {
            case 1:Task1();
                break;
            case 2:Task2();
                break;
            default:
                Console.WriteLine("Enter correct choise");
                break;
        }
    }
    
    public static bool Task1() //1 Варiант
    {
        string a = "abcdefghijlkmnopqrstuv18340"; 
        string b = "abcdefghijlkmnoasdfadpqrstuv18340";
        bool result = Regex.IsMatch(a, b);
        return result;
    }

    public static bool Task2() //8 Варiант
    {
        string a = "127.0.0.1, 255.255.255.111";
        string b = "1300.6.7.8, abc.def.gha.bcd";
        string correct = @"[0-255].[0-255].[0-255].[0-255]";
        bool result = Regex.IsMatch(b, correct);
        return result;
    }
    static void Main()
    {
        Task();
    }
}