using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class TheKingsArmyDiv1
{
    const int INF = int.MaxValue / 2;

    string[] state;
    int?[,,] memo;

    public int getNumber(string[] state)
    {
        this.state = state;
        memo = new int?[state [0].Length, state [0].Length + 1, 3];
        var res = dfs(0, state [0].Length, 2);
        return res >= INF ? -1 : res;
    }

    int dfs(int s, int e, int f)
    {
        if (memo [s, e, f].HasValue)
            return memo [s, e, f].Value;

        int res = INF;
        if (f < 2)
        {
            bool ok = true;
            for (int i = s; i < e; i++)
            {
                if (state [f] [i] == 'S')
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                memo [s, e, f] = 0;
                return 0;
            }
        }


        if (s + 1 < e)
        {
            int ll = Math.Min(dfs(s + 1, e, f), dfs(s + 1, e, 2)) + 1;
            int rr = Math.Min(dfs(s, e - 1, f), dfs(s, e - 1, 2)) + 1;
            res = Math.Min(res, Math.Min(ll, rr));

            for (int i = s + 1; i < e; i++)
            {
                int lll = Math.Min(dfs(s, i, f), dfs(s, i, 2));
                int rrr = Math.Min(dfs(i, e, f), dfs(i, e, 2));
                res = Math.Min(res, lll + rrr);
            }
        }

        if (f == 2)
        {
            res = Math.Min(res, dfs(s, e, 0) + dfs(s, e, 1));
            res = Math.Min(res, Math.Min(dfs(s, e, 0), dfs(s, e, 1)) + 1);
        }
        memo [s, e, f] = res;
        return res;
    }
}
