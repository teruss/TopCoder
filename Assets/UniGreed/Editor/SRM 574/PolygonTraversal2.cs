using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class PolygonTraversal2
{
    int N;
    bool[] visited = new bool[14];
    int[] points = new int[13];
    
    bool cross(int x, int y, int t)
    {
        if (x > y)
            return cross(y, x, t);
        
        for (int i=0; i+1<t; i++)
        {
            if (points [i] == x || points [i + 1] == x)
                continue;
            if (points [i] == y || points [i + 1] == y)
                continue;
            bool p1 = (x < points [i] && points [i] < y);
            bool p2 = (x < points [i + 1] && points [i + 1] < y);
            
            if (p1 != p2)
                return true;
        }
        return false;
    }
    
    int rec(int t)
    {
        if (t == N)
        {
            return cross(points [t - 1], points [0], t) ? 1 : 0;
        }
        int res = 0;
        for (int i = 1; i <=N; i++)
        {
            if (!visited [i] && cross(points [t - 1], i, t))
            {
                visited [i] = true;
                points [t] = i;
                res += rec(t + 1);
                visited [i] = false;
            }
        }
        return res;
    }
    
    public int count(int N, int[] points)
    {
        this.N = N;
        for (int i = 0; i < points.Length; i++)
        {
            visited [points [i]] = true;
            this.points [i] = points [i];
        }
        return rec(points.Length);
    }
}
