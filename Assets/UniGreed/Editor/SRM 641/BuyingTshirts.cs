using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class BuyingTshirts
{
    public int meet(int T, int[] Q, int[] P)
    {
        Func<int[], List<bool>> f = q => {
            var x = new List<bool>(q.Length);
            q.Aggregate(0, (sum, value) => {
                sum += value;
                x.Add(sum >= T);
                return sum % T;
            });
            return x;
        };

        return f(Q).Zip(f(P), (q, p) => q && p).Count(b => b);
    }

}
