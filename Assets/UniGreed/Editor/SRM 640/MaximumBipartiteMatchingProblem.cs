using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class MaximumBipartiteMatchingProblem
{
    long N1, N2, A, D;
    long val(long v)
    {
        if (v < D)
            return -1;
        if (A - v < D)
            return -1;
        return N1 * v + (A - v) * (N2 - v);
    }

    void swap<type>(ref type lhs, ref type rhs)
    {
        var tmp = lhs;
        lhs = rhs;
        rhs = tmp;
    }

    public long solve(int n1, int n2, int ans, int d)
    {
        N1 = n1;
        N2 = n2;
        A = ans;
        D = d;
        
        if (N1 < N2) 
            swap(ref N1, ref N2);
        if (N2 == A)
            return N1 * N2;
        if (A < 2 * D)
            return -1;
        long ret = -1;
        ret = Math.Max(ret, val(0));
        ret = Math.Max(ret, val(D));
        ret = Math.Max(ret, val(A - D));
        ret = Math.Max(ret, val(N1));
        ret = Math.Max(ret, val(N2));
        ret = Math.Max(ret, val((A + N2 - N1) / 2));
        ret = Math.Max(ret, val((A + N2 - N1) / 2 + 1));
        return ret;
    }

}
