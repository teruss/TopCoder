using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class AliceGame
{
    public long findMinimumValue(long x, long y)
    {
        long sum = x + y;
        long n = (long)Math.Sqrt(sum);
        if (n * n != sum)
            return -1;

        if (x == 0)
            return 0;
        if (y == 0)
            return n;

        long res = 0;
        for (; x > 0; n--)
        {
            if (x > n * n)
                return -1;
            if (x >= n * 2 - 1 && x - n * 2 + 1 != 2)
            {
                x -= n * 2 - 1;
                res++;
            }
        }
        return res;
    }

}
