using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Satellites
{
    public struct Vector3
    {
        public double x, y, z;
        public static readonly Vector3 Zero = new Vector3();
        
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public double Norm()
        {
            return Math.Sqrt(Sqr());
        }
        
        public double Sqr()
        {
            return x * x + y * y + z * z;
        }
        
        public static Vector3 FromSphericalCoordinates(double lat, double lng, double alt)
        {
            return new Vector3(Math.Sin(lng) * Math.Cos(lat), Math.Sin(lat), Math.Cos(lng) * Math.Cos(lat)) * alt;
        }
        
        public static Vector3 operator+(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        
        public static Vector3 operator-(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        
        public static Vector3 operator*(Vector3 lhs, double rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }
        
        public static bool operator==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
        }
        
        public static bool operator!=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var v = (Vector3)obj;
            return this == v;
        }
        
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
        }
        
        public static double Dot(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }
        
        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        }
        
        public static double Distance(Vector3 lhs, Vector3 rhs)
        {
            return (rhs - lhs).Norm();
        }
        
        public override string ToString()
        {
            return string.Format("[Vector3]:" + x + "," + y + "," + z);
        }
    }

    public class Mathf
    {
        public const double Deg2Rad = Math.PI * 2 / 360;
    }

    public class Util
    {
        public static double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180;
        }
        
        //Compute the distance from AB to C
        //if isSegment is true, AB is a segment, not a line.
        public static double LinePointDistance(Vector3 A, Vector3 B, Vector3 C, bool isSegment)
        {
            if (A == B)
            {
                if (isSegment)
                    return Vector3.Distance(A, C);
                throw new ArithmeticException();
            }
            double dist = Cross(A, B, C) / Vector3.Distance(A, B);
            if (isSegment)
            {
                double dot1 = Dot(A, B, C);
                if (dot1 > 0)
                    return Vector3.Distance(B, C);
                double dot2 = Dot(B, A, C);
                if (dot2 > 0)
                    return Vector3.Distance(A, C);
            }
            return Math.Abs(dist);
        }
        
        //Compute the cross product AB x AC
        public static double Cross(Vector3 A, Vector3 B, Vector3 C)
        {
            return Vector3.Cross(B - A, C - A).Norm();
        }
        
        //Compute the dot product AB ⋅ BC
        public static double Dot(Vector3 A, Vector3 B, Vector3 C)
        {
            return Vector3.Dot(B - A, C - B);
        }
    }

    public int[] detectable(string[] rockets, string[] satellites)
    {
        var rocketPositions = rockets.Select(rocket => {
            var x = rocket.Split();
            return Vector3.FromSphericalCoordinates(Mathf.Deg2Rad * double.Parse(x [0]), Mathf.Deg2Rad * double.Parse(x [1]), 6400 + 400);
        });

        var satellitePositions = satellites.Select(satellite => {
            var x = satellite.Split();
            return Vector3.FromSphericalCoordinates(Mathf.Deg2Rad * double.Parse(x [0]), Mathf.Deg2Rad * double.Parse(x [1]), 6400 + double.Parse(x [2]));
        });

        return rocketPositions.Select((rocket, index) => new { rocket = rocket, index = index }).Where(x =>
            satellitePositions.Count(satellite =>
                 Util.LinePointDistance(x.rocket, satellite, Vector3.Zero, true) > 6400
        ) >= 3
        ).Select(x => x.index).ToArray();
    }

}
