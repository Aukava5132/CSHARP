namespace Lab6;

public class Threeangle
{
    protected double _a;
    protected double _b;
    protected double _c;

    public Threeangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public Threeangle() //a = b = c = 0
    {

    }

    public double a
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

    public double b
    {
        get => _b;
        set
        {
            if (value > 0)
            {
                _b = value;
            }
        }
    }

    public double c
    {
        get => _c;
        set
        {
            if (value > 0)
            {
                _c = value;
            }
        }
    }

    public virtual double Sthreeangle()
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }

    public virtual double[] CalculateAngles()
    {
        double[] angles = new double[3];
        angles[0] = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
        angles[1] = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
        angles[2] = 180 - angles[0] - angles[1];
        return angles;
    }
    
    public override string ToString()
    {
        return $"Трикутник зі сторонами: {a}, {b}, {c}";
    }
    
    public override int GetHashCode()
    {
        return (a, b, c).GetHashCode();
    }
}