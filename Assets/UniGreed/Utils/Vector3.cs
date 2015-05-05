using System;

namespace HebiLib
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
}
