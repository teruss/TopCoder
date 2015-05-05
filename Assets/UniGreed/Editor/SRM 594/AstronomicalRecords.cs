using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class AstronomicalRecords
{
    public int minimalPlanets(int[] _A, int[] _B)
    {
        var A = Fix(_A);
        var B = Fix(_B);
        int nA = A.Length;
        int nB = B.Length;
        int res = nA + nB;

        for (int i = 0; i < nA; i++)
        {
            for (int j = 0; j < nB; j++)
            {
                res = Math.Min(res, Sub(A, B, i, j));
            }
        }
        return res;
    }

    long[] Fix(int[] C)
    {
        return Array.ConvertAll<int, long>(C, (i) => {
            return (long)i;
        });
    }

    int Sub(long[] A, long[] B, int i, int j)
    {
        long p = A [i];
        long q = B [j];

        var a = (from x in A select x * q).ToArray();
        var b = (from x in B select x * p).ToArray();

        int nA = A.Count(), nB = B.Count();
        var dp = new int [nA + 1, nB + 1];
        for (int s = 0; s <= nA; s++)
        {
            for (int t = 0; t <= nB; t++)
            {
                if (s == 0 || t == 0)
                {
                    dp [s, t] = 0;
                } else
                {
                    bool eq = a [s - 1] == b [t - 1];
                    dp [s, t] = new []
                    {
                        dp [s - 1, t],
                        dp [s, t - 1],
                        Convert.ToInt32(eq) + dp [s - 1, t - 1]
                    }.Max();
                }
            }
        }
        return nA + nB - dp [nA, nB];
    }
}
