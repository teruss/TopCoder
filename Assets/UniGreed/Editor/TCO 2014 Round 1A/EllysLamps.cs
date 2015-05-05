using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class EllysLamps
{
    int?[,,,] dp;
    int[] lamps;

    public int getMin(string lamps)
    {
        dp = new int?[lamps.Length, 2, 2, 2];
        this.lamps = lamps.Select(c => c == 'Y' ? 1 : 0).ToArray();
        return Recursive(0, this.lamps [0], 0, 0);
    }

    int Recursive(int idx, int lit, int addU, int addN)
    {
        if (idx == lamps.Length - 1)
            return Math.Min(lit + addN, lit ^ 1 + addU);
        if (dp [idx, lit, addU, addN].HasValue)
            return dp [idx, lit, addU, addN].Value;

        int ans = 0;
        for (int changeLeft = 0; changeLeft<2; changeLeft++)
        {
            for (int changeRight = 0; changeRight < 2; changeRight++)
            {
                ans = Math.Max(
                    ans, Math.Min(
                    Recursive(idx + 1, lamps [idx + 1] ^ changeRight, lit ^ changeLeft ^ 1, lit ^ 1) + addU,
                    Recursive(idx + 1, lamps [idx + 1], lit ^ changeLeft, lit) + addN));
            }
        }
        dp [idx, lit, addU, addN] = ans;
        return ans;
    }
}
