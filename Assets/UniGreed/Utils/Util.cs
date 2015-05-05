using System;
using System.Collections;
using System.Collections.Generic;

namespace HebiLib
{
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
}
