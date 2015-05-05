using UnityEngine;
using System.Collections;

namespace HebikuboLib
{
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
