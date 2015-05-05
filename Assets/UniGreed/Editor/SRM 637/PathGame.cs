using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class PathGame
{
    int[,,] memo = new int[1001, 4, 4];

    public string judge(string[] board)
    {
        int n = board [0].Length;
        var bd = new int[2, n];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < n; j++)
                bd [i, j] = board [i] [j] == '#' ? 1 : 0;
        
        for (int i = 0; i < memo.GetLength(0); i++)
            for (int j = 0; j < memo.GetLength(1); j++)
                for (int k = 0; k < memo.GetLength(2); k++)
                    memo [i, j, k] = -1;
        int nim = 0;
        int b = 0;
        while (b < n)
        {
            if (bd [0, b] == 0 && bd [1, b] == 0)
            {
                int a = b;
                while (b<n && bd[0,b]==0 && bd[1,b]==0)
                    b++;
                
                int lstate = 0;
                if (a != 0)
                    lstate = bd [0, a - 1] + (bd [1, a - 1] << 1);
                int rstate = 0;
                if (b != n)
                    rstate = bd [0, b] + (bd [1, b] << 1);
                
                nim ^= nimber(b - a, lstate, rstate);
            } else
            {
                b++;
            }
        }
        return nim != 0 ? "Snuke" : "Sothe";
    }

    int nimber(int w, int l, int r)
    {
        if (w == 0)
            return 0;
        if (w == 1)
        {
            if (l == r)
                return 1;
            if (l == 0)
                return 1;
            if (r == 0)
                return 1;
            return 0;
        }
        if (memo [w, l, r] != -1)
            return memo [w, l, r];
        
        var ss = new HashSet<int>();
        if (l != 2)
            ss.Add(nimber(w - 1, 1, r));
        if (l != 1)
            ss.Add(nimber(w - 1, 2, r));
        if (r != 2)
            ss.Add(nimber(w - 1, l, 1));
        if (r != 1)
            ss.Add(nimber(w - 1, l, 2));
        
        for (int i=1; i<w-1; i++)
        {
            ss.Add(nimber(i, l, 1) ^ nimber(w - i - 1, 1, r));
            ss.Add(nimber(i, l, 2) ^ nimber(w - i - 1, 2, r));
        }
        
        int nim = 0;
        while (ss.Contains(nim))
            nim++;
        memo [w, l, r] = nim;
        return nim;
    }
}
