using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class WheelofFortune
{
    public double maxExpectedValue(int N, int[] s)
    {
        int L = s.Length;
        var dp = new double[303];
        var op = new double[2, 303, 303];
        
        dp [0] = 1;
        
        for (int i = 0; i < L; i++)
        {
            int cur = i % 2;
            int tar = cur ^ 1;
            for (int j = 0; j < 303; j++)
            {
                for (int k = 0; k < 303; k++)
                {
                    op [tar, j, k] = 0;
                }
            }
            double p = s [i] * 1.0 / N;
            
            for (int y=1; y<=N/2; y++)
            {
                var dp2 = new double[303];
                for (int x=i+1; x>=0; x--)
                    if (dp [x] > 0)
                    {
                        if (s [i] == N)
                        {
                            dp2 [x + 1] += dp [x];
                            op [tar, y, x + 1] += dp [x] * (op [cur, y, x] + 1);
                        } else
                        {
                            dp2 [x + 1] += dp [x] * p;
                            dp2 [x] += dp [x] * (1 - p);
                            op [tar, y, x + 1] += dp [x] * p * (op [cur, y, x] + (Math.Max(0, s [i] - y) + Math.Max(0, s [i] - (N - y))) * 1.0 / s [i]);
                            op [tar, y, x] += dp [x] * (1 - p) * (op [cur, y, x] + (1 + Math.Min(y, N - s [i]) - Math.Max(1, y - (s [i] - 1))) * 1.0 / (N - s [i]));
                        }
                    }
                for (int x=i+1; x>=0; x--)
                    if (dp2 [x] > 0)
                        op [tar, y, x] /= dp2 [x];
            }
            for (int x=i+1; x>=0; x--)
            {
                dp [x + 1] += dp [x] * p;
                dp [x] *= 1 - p;
            }
        }
        
        double ret = 0;
        for (int i = 0; i < L+1; i++)
        {
            double ma = 0;
            for (int x=1; x<=N/2; x++)
                ma = Math.Max(ma, op [L % 2, x, i]);
            ret += dp [i] * (i + ma);
        }
        return ret;
    }

}
