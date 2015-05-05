using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class TwoNumberGroupsEasy
{
    int[] A, numA, B, numB;
    int dist2(int M)
    {
        var m1 = new Dictionary<int, long>();
        var m2 = new Dictionary<int, long>();
        long ret = 0;
        for (int i = 0; i < A.Length; i++)
        {
            var key = A [i] % M;
            if (!m1.ContainsKey(key))
                m1 [key] = 0;
            m1 [key] += numA [i];
            ret += numA [i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            var key = B [i] % M;
            if (!m2.ContainsKey(key))
                m2 [key] = 0;
            m2 [key] += numB [i];
            ret += numB [i];
        }
        foreach (var it in m1)
        {
            ret -= 2 * Math.Min(it.Value, m2.ContainsKey(it.Key) ? m2 [it.Key] : 0);
        }
        return (int)ret;
    }
    
    int dist(int M)
    {
        if (M <= 1)
            return 1 << 30;
        int i;
        int ret = dist2(M);
        for (i=2; i*i<=M; i++)
            if (M % i == 0)
            {
                ret = Math.Min(ret, dist2(i));
                ret = Math.Min(ret, dist2(M / i));
            }
        return ret;
    }

    public int solve(int[] A_, int[] numA_, int[] B_, int[] numB_)
    {
        A = A_;
        B = B_;
        numA = numA_;
        numB = numB_;
        int ret = dist(1 << 30);
        for (int x = 0; x < A.Length; x++)
            if (A [x] > 1)
                ret = Math.Min(ret, dist(A [x]));
        for (int x = 0; x < B.Length; x++)
            if (B [x] > 1)
                ret = Math.Min(ret, dist(B [x]));
        for (int x = 0; x < A.Length; x++)
            for (int y = 0; y < A.Length; y++)
                ret = Math.Min(ret, dist(Math.Abs(A [x] - A [y])));
        for (int x = 0; x < A.Length; x++)
            for (int y = 0; y < B.Length; y++)
                ret = Math.Min(ret, dist(Math.Abs(A [x] - B [y])));
        for (int x = 0; x <B.Length; x++)
            for (int y = 0; y < B.Length; y++)
                ret = Math.Min(ret, dist(Math.Abs(B [x] - B [y])));
        
        return ret;
    }

}
