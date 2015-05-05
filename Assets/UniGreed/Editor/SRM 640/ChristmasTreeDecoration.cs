using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class ChristmasTreeDecoration
{
    public int solve(int[] col, int[] x, int[] y)
    {
        int ret = 0;
        var uf = new UF();
        for (int i=0; i<x.Length; i++)
            if (col [x [i] - 1] != col [y [i] - 1])
                uf.unite(x [i] - 1, y [i] - 1);
        for (int i=0; i<col.Length; i++)
            if (uf [i] == i)
                ret++;
        return ret - 1;
    }

    public class UF
    {
        const int ufmax = 152;
        int[] ufpar = new int[ufmax];
        int[] ufrank = new int[ufmax];
        int[] ufcnt = new int[ufmax];
        public UF()
        {
            init();
        }
        void init()
        {
            for (int i=0; i<ufmax; i++)
            {
                ufpar [i] = i;
                ufrank [i] = 0;
                ufcnt [i] = 1;
            }
        }
        int find(int x)
        {
            return (ufpar [x] == x) ? (x) : (ufpar [x] = find(ufpar [x]));
        }
        public int this [int x]
        {
            get{ return find(x);}
        }
        int count(int x)
        {
            return ufcnt [find(x)];
        }
        public void unite(int x, int y)
        {
            x = find(x);
            y = find(y);
            if (x == y)
                return;
            if (ufrank [x] < ufrank [y])
            {
                ufpar [x] = y;
                ufcnt [y] += ufcnt [x];
            } else
            {
                ufpar [y] = x;
                ufcnt [x] += ufcnt [y];
                if (ufrank [x] == ufrank [y])
                    ufrank [x]++;
            }
        }
    }
}

