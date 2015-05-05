using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class BitwiseAnd
{
    public long[] lexSmallest(long[] subset, int N)
    {
        var bitGroup = new long[64];
        for (int i = 0; i < subset.Length; i++)
        {
            for (int j = i + 1; j < subset.Length; j++)
            {
                var x = subset [i] & subset [j];
                if (x == 0)
                {
                    return new long[] {};
                }
                for (int k = j + 1; k < subset.Length; k++)
                {
                    if ((x & subset [k]) != 0)
                    {
                        return new long[]{};
                    }
                }
            }
            int c = 0;
            for (int j = 0; j < 64; j++)
            {
                long x = (1L << j);
                if ((subset [i] & x) == x)
                {
                    bitGroup [j] |= (1L << i);
                    if (BitCount(bitGroup [j]) > 2)
                        return new long[]{};
                    c++;
                }
            }
            if (c < N - 1)
                return new long[]{};
        }
        var res = new List<long>(subset);

        const long limit = (1L << 60);
        while (res.Count < N)
        {
            long l = 0;
            long c = 0;
            for (int i = 0; i < 64; i++)
            {
                if (BitCount(bitGroup [i]) == 1)
                {
                    if ((c & bitGroup [i]) == 0)
                    {
                        l |= (1L << i);
                        c |= bitGroup [i];
                        bitGroup [i] |= (1L << res.Count);

                        if (l >= limit)
                            return new long[]{};
                        bitGroup [i] |= (1L << res.Count);
                        if (BitCount(l) == N - 1)
                            break;
                    }
                }
            }

            while (BitCount(l) < N - 1)
            {
                for (int j = 0; j < 64; j++)
                {
                    if (BitCount(bitGroup [j]) == 0)
                    {
                        l |= (1L << j);
                        if (l >= limit)
                            return new long[]{};
                        bitGroup [j] |= (1L << res.Count);
                        if (BitCount(l) == N - 1)
                            break;
                    }
                }
            }
            res.Add(l);
        }
        res.Sort();

        return res.ToArray();
    }

    int BitCount(long bits)
    {
        int res = 0;
        while (bits > 0)
        {
            if ((bits & 1) == 1)
                res++;
            bits >>= 1;
        }
        return res;
    }
}
