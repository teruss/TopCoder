using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class WaitingForBus
{
    public double whenWillBusArrive(int[] time, int[] prob, int s)
    {
        int timeMax = time.Max();
        var p = new double[s + timeMax];
        p [0] = 1;
        for (int t = 0; t < s; t++)
        {
            for (int i = 0; i < time.Length; i++)
            {
                p [t + time [i]] += p [t] * prob [i] / 100;
            }
        }
        return p.Skip(s).Zip(Enumerable.Range(0, timeMax), (t1, t2) => t1 * t2).Aggregate((sum, value) => sum + value);
    }

}
