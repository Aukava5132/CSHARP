namespace Lab6p2
{
    public class Soilder : Worker
    {
        private string _rank;
        
        public Soilder(string name,string lastname, int age, int exp, string rank):base(name,lastname,age,exp)
        {
            Rank = rank;
        }

        public Soilder():base()
        {
            Rank = "";
        }

        public string Rank
        {
            get => _rank;
            set => _rank = value;
        }

        public override void Display()
        {
            Console.WriteLine($"[Soilder] \n Name: {Name} {LastName} \n Age: {Age} \n Exp: {Exp} \n Rank: {Rank}\n");
        }
    }
    
   
}