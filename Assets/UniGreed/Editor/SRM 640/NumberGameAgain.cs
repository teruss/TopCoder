using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class NumberGameAgain
{
    public long solve(int k, long[] table)
    {
        int N = table.Length;
        var ng = new int[30];
        var msb = new int[30];

        Array.Sort(table);

        for (int i = 0; i < N; i++)
            while (1L<<(1+msb[i])<=table[i])
                msb [i]++;
        for (int i = 0; i < N; i++)
            for (int j=i+1; j<N; j++)
                if ((table [j] >> (msb [j] - msb [i])) == table [i])
                    ng [j]++;
        
        long ret = (1L << k) - 2;
        for (int i = 0; i < N; i++)
            if (ng [i] == 0)
                ret -= (1L << (k - msb [i])) - 1;
        return ret;
    }

}
