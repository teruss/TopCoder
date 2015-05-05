using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TrianglesContainOrigin
{
    public long count(int[] x, int[] y)
    {
        var args = x.Zip(y, (xx, yy) => Math.Atan2(yy, xx)).OrderBy(v => v).ToList();
        return Enumerable.Range(0, args.Count).Aggregate(0L, (acc, i) => {
            var li = args.BinarySearch(args [i] + Math.PI);
            if (li < 0)
                li = ~li;
            for (int j = i + 1; j < args.Count; j++)
            {
                if (args [j] < args [i] + Math.PI)
                {
                    var lj = args.BinarySearch(args [j] + Math.PI);
                    if (lj < 0)
                        lj = ~lj;
                    acc += lj - li;
                }
            }
            return acc;
        });
    }

}
