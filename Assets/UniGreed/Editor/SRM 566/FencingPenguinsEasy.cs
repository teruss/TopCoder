using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class FencingPenguinsEasy
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
    public double calculateMinArea(int numPosts, int radius, int[] x, int[] y)
    {
        var posts = new Vector2[numPosts];
        for (int i = 0; i < numPosts; i++)
        {
            var t = Math.PI * 2 / numPosts * i;
            posts [i] = new Vector2(Math.Cos(t), Math.Sin(t)) * radius;
        }

        var n = x.Length;
        var penguins = new Vector2[n];
        for (int i = 0; i < n; i++)
        {
            penguins [i] = new Vector2(x [i], y [i]);
        }

        var valid = new bool[numPosts, numPosts];
        for (int i = 0; i < numPosts; i++)
        {
            for (int j = 0; j < numPosts; j++)
            {
                if (i != j)
                    valid [i, j] = penguins.All(penguin => Vector2.Cross(posts [i] - penguin, posts [j] - penguin) > 0);
            }
        }

        for (int i = 0; i < numPosts; i++)
        {
            if (!valid [i, (i + 1) % numPosts])
                return -1;
        }
        var dp = new double[numPosts, numPosts];

        for (int dif = 1; dif < numPosts; dif++)
        {
            for (int l = 0; l +dif< numPosts; l++)
            {
                int r = l + dif;
                dp [l, r] = 1e50;
                for (int nl = l + 1; nl <= r; nl++)
                {
                    if (valid [l, nl])
                        dp [l, r] = Math.Min(dp [l, r], Vector2.Area(posts [l], posts [nl], posts [r]) + dp [nl, r]);
                }
            }
        }

        double res = 1e50;
        for (int l = 0; l < numPosts; l++)
        {
            for (int r = l+2; r < numPosts; r++)
            {
                if (valid [r, l])
                {
                    res = Math.Min(res, dp [l, r]);
                }
            }
        }
        return res;
    }

}
