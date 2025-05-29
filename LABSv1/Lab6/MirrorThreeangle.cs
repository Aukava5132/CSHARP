namespace Lab6
{
    public class MirrorThreeangle : Threeangle
    {
        private double _b;
        public MirrorThreeangle(double a,double b):base(a)
        {
            B = b;
        }
        public MirrorThreeangle() 
        { 

        }

        public double B
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
        public override double Sthreeangle()
        {
            double p = (A * 2 + B) / 2;
            double s = B * Math.Sqrt(4 * A * A * A - B * B) / 4;
            return s;
        }
    }
}