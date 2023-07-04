
namespace Shape
{
    public interface ISquare
    {
        public double CountSquare();
    }

    public class Circle : ISquare // Circle class
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            private set { if(value > 0) _radius = value; }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CountSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : ISquare // Triangle class
    {
        private double _a;
        private double _b;
        private double _c;
        public double A
        {
            get { return _a; }
            private set{ if (value > 0) _a = value;}
        }
        public double B
        {
            get { return _b; }
            private set { if (value > 0) _b = value; }
        }
        public double C
        {
            get { return _c; }
            private set { if (value > 0) _c = value; }
        }
        public Triangle(double a, double b, double c)
        {
            if(a < b + c && b < a + c && c < a + b) // Checking existing of those triangle
            {
                A = a;
                B = b;
                C = c;
            }
        }
        public double CountSquare()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
        public bool IsOrthogonal()
        {
            // Counting squares of sides
            double ASquare = _a * _a;
            double BSquare = _b * _b;
            double CSquare = _c * _c;
            // Checking the Pythagorean theorem
            if (ASquare == BSquare + CSquare) return true;
            if (BSquare == ASquare + CSquare) return true;
            if (CSquare == ASquare + BSquare) return true;
            return false;
        }
    }
}