using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ShufflingCardsDiv1
{
    public int shuffle(int[] permutation)
    {
        int n = permutation.Length;
        if (Enumerable.Range(1, n).SequenceEqual(permutation))
            return 0;

        var org = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            org [permutation [i]] = i % 2;
        }
        
        int change = n / 4;
        int cnt = 0;
        for (int i=1; i <=n/2; i++)
        {
            cnt += org [i];
        }
        if (cnt == 0)
            return 1;
        if (cnt < change)
        {
            return 3;
        }
        return (cnt + change - 1) / change + 1;
    }

}
