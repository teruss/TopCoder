using System;

namespace HebiLib
{
    public struct Vector2
    {
        public double x, y;
        public static readonly Vector2 Zero = new Vector2();
        
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public double Norm()
        {
            return Math.Sqrt(Sqr());
        }
        
        public double Sqr()
        {
            return x * x + y * y;
        }
        
        public static Vector2 operator+(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }
        
        public static Vector2 operator-(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }
        
        public static Vector2 operator*(Vector2 lhs, double rhs)
        {
            return new Vector2(lhs.x * rhs, lhs.y * rhs);
        }
        
        public static bool operator==(Vector2 lhs, Vector2 rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y;
        }
        
        public static bool operator!=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var v = (Vector2)obj;
            return this == v;
        }
        
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
        
        public static double Dot(Vector2 lhs, Vector2 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }
        
        public static double Cross(Vector2 lhs, Vector2 rhs)
        {
            return lhs.x * rhs.y - lhs.y * rhs.x;
        }

        public static double Area(Vector2 a, Vector2 b, Vector2 c)
        {
            return Math.Abs(Cross(b - a, c - a)) / 2;
        }
        
        public static double Distance(Vector2 lhs, Vector2 rhs)
        {
            return (rhs - lhs).Norm();
        }
        
        public override string ToString()
        {
            return string.Format("[Vector2]:" + x + "," + y);
        }
    }
}
