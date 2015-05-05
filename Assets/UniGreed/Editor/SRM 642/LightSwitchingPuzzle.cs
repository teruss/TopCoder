using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class LightSwitchingPuzzle
{
    public int minFlips(string state)
    {
        var arr = state.ToCharArray();
        return Enumerable.Range(0, state.Length).Aggregate(0, (sum,i) => {
            if (arr [i] == 'Y')
            {
                for (int j = i+1; j <= arr.Length; j += i + 1)
                {
                    arr [j - 1] = arr [j - 1] == 'Y' ? 'N' : 'Y';
                }
                return sum + 1;
            }
            return sum;
        });
    }
}
