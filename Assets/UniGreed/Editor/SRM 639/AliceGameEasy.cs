using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class AliceGameEasy
{
    public long findMinimumValue(long x, long y)
    {
        long sum = x + y;
        long n = (long)Math.Sqrt(sum * 2);
        if (sum != n * (n + 1) / 2)
        {
            return -1;
        }
        if (x == 0)
            return 0;
        if (y == 0)
            return n;
        if (x <= n)
            return 1;

        long res = 1;
        while (x > n)
        {
            x -= n;
            n--;
            res++;
            if (x <= 0)
                break;
        }
        return res;
    }

}
