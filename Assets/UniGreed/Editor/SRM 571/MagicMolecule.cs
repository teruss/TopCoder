using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class MagicMolecule
{
    int[] magicPower;
    List<KeyValuePair<int,int>> notBonds;
    int n, m;

    public int maxMagicPower(int[] magicPower, string[] magicBond)
    {
        n = magicBond.Length;
        m = (2 * n + 2) / 3;
        this.magicPower = magicPower;
        notBonds = new List<KeyValuePair<int, int>>();

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (magicBond [i] [j] == 'N')
                {
                    notBonds.Add(new KeyValuePair<int, int>(i, j));
                }
            }
        }

        return dfs(0, 0L, n - m);
    }

    int dfs(int index, long notUsed, int k)
    {
        if (k < 0)
            return -1;
        if (index == notBonds.Count)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (((1L << i) & notUsed) == 0)
                {
                    res += magicPower [i];
                }
            }
            return res;
        }
        var notBond = notBonds [index];
        if ((notUsed & (1L << notBond.Key)) != 0 || (notUsed & (1L << notBond.Value)) != 0)
            return dfs(index + 1, notUsed, k);
        var l1 = notUsed | (1L << notBond.Key);
        var l2 = notUsed | (1L << notBond.Value);
        return Math.Max(dfs(index + 1, l1, k - 1), dfs(index + 1, l2, k - 1));
    }
}
