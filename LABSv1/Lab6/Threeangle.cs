namespace Lab6;

public class Threeangle
{
    private double _a;

    public Threeangle(double a)
    {
        A = a;
    }

    public Threeangle() //a = 0
    {

    }

    public double A
    {
        get => _a;
        set
        {
            if (value > 0)
            {
                _a = value;
            }
        }
    }

    public virtual double Sthreeangle()
    {
        double s = (A * A * Math.Sqrt(3))/4;
        return s;
    }

    public override string ToString()
    {
        return $"Трикутник зі сторонами: {A}, {A}, {A}";
    }
    public override bool Equals(object? obj) 
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        Threeangle threeangle = (Threeangle)obj;
        return A == threeangle.A;
    }
    public override int GetHashCode()
    {
        return (A).GetHashCode();
    }
}