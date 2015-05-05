using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StringsNightmareAgain
{
    const int N = 100001;
    const int M = 1 << 18;
    const int INF = 0x3f3f3f3f;
    char[] ins = new char[N];
    int[] S = new int[N];
    int[] pos = new int[N];
    int[] aux = new int[N];
    int[] lcp = new int[N];
    int t, len;
    int[] up = new int[N];
    int[] down = new int[N];
    int[][] seg = new int[3] [];

    public long UniqueSubstrings(int a, int b, int c, int d, int n)
    {
        for (int i = 0; i < seg.Length; i++)
        {
            seg [i] = new int[M];
        }
        // build string
        for (int i = 0; i < n; ++i)
            ins [i] = 'a';
        for (int i = 0; i < a; ++i)
        {
            b = (int)((1L * b * c + d) % n);
            ins [b] = 'b';
        }
        ins [n] = '\0';
        // solve
        build();
        return solve();
    }

    // segment tree
    void update(ref int[] seg, int p, int a, int b, int i, int v)
    {
        if (a > i || b < i)
            return;
        if (a == b)
        {
            seg [p] = v;
            return;
        }
        update(ref seg, p * 2, a, (a + b) / 2, i, v);
        update(ref seg, p * 2 + 1, (a + b) / 2 + 1, b, i, v);
        seg [p] = Math.Min(seg [p * 2], seg [p * 2 + 1]);
    }
    
    int query(ref int[] seg, int p, int a, int b, int i, int j)
    {
        if (a > j || b < i)
            return INF;
        if (a >= i && b <= j)
            return seg [p];
        int x = query(ref seg, p * 2, a, (a + b) / 2, i, j);
        int y = query(ref seg, p * 2 + 1, (a + b) / 2 + 1, b, i, j);
        return Math.Min(x, y);
    }
    
    // suffix array compare
    class SuffixComparer : IComparer<int>
    {
        int[] pos;
        int t, len;

        public SuffixComparer(int[] pos, int t, int len)
        {
            this.pos = pos;
            this.t = t;
            this.len = len;
        }

        public int Compare(int a, int b)
        {
            if (pos [a] != pos [b])
                return pos [a].CompareTo(pos [b]);
            a += t;
            b += t;
            if (a >= len || b >= len)
                return a.CompareTo(b);
            if (pos [a] != pos [b])
                return pos [a].CompareTo(pos [b]);
            return 1;
        }

        public int Result(int a, int b)
        {
            return Compare(a, b) < 0 ? 1 : 0;
        }
    }
    
    // generating information to solve problem
    void build()
    {
        for (int i = 0; i < seg.Length; i++)
        {
            for (int j = 0; j < seg[i].Length; j++)
            {
                seg [i] [j] = INF;
            }
        }
        len = new String(ins).TrimEnd('\0').Length;
        // suffix array
        for (int i = 0; i < len; ++i)
        {
            pos [i] = ins [i];
            S [i] = i;
        }
        for (t = 1;; t*=2)
        {
            var comparer = new SuffixComparer(pos, t, len);
            Array.Sort(S, 0, len, comparer);
            for (int i = 1; i < len; ++i)
            {
                aux [i] = aux [i - 1] + comparer.Result(S [i - 1], S [i]);
            }
            for (int i = 0; i < len; ++i)
                pos [S [i]] = aux [i];
            if (aux [len - 1] == len - 1)
                break;
        }
        // lcp
        for (int i = 0, k = 0; i < len; ++i)
            if (pos [i] != len - 1)
            {
                for (int j = S[pos[i] + 1]; ins[i + k] == ins[j + k];)
                {
                    ++k;
                }
                lcp [pos [i]] = k;
                if (k > 0)
                    --k;
            }
        // ranges
        for (int i = len-1; i >= 0; --i)
        {
            if (i > len - 3)
            {
//                for (int j = 0; j < len; j++)
//                {
//                    UnityEngine.Debug.Log("j:" + j + "," + seg [0] [j]);
//                }
            }
            int p = query(ref seg [0], 1, 0, len - 1, 0, lcp [i] - 1);
            up [i] = p;
            if (i > len - 3)
            {
//                UnityEngine.Debug.Log("i:" + i + "," + up [i] + "," + lcp [i]);
            }
            update(ref seg [0], 1, 0, len - 1, lcp [i], i);
        }
        for (int j = 0; j < seg[0].Length; j++)
        {
            seg [0] [j] = 0;
        }
        for (int i = 0; i < len; ++i)
        {
            int p = -query(ref seg [0], 1, 0, len - 1, 0, lcp [i] - 1);
            down [i] = p;
            update(ref seg [0], 1, 0, len - 1, lcp [i], -(i + 1));
        }
        // left and right
        for (int i = 0; i < len; ++i)
        {
//            UnityEngine.Debug.Log("i:" + i + "," + S [i]);
            update(ref seg [1], 1, 0, len - 1, i, S [i]);
            update(ref seg [2], 1, 0, len - 1, i, -S [i]); // max, multiply by -1 ;D
        }
        // print some info
//        for (int i = 0; i < len; ++i)
//            UnityEngine.Debug.Log("i:" + i + "," + lcp [i] + ' ' + down [i] + ' ' + up [i] + ' ' + new string(ins, S [i], len - S [i]));
    }
    
    // everything is calculated, now just solve it using info we generated
    long solve()
    {
        long res = 0;
        int k = 0;
        for (int i = 0; i < len-1; ++i)
        {
            if (lcp [i] == 0)
            {
                k = 0;
                continue;
            }
            int now = lcp [i];
            int lef = query(ref seg [1], 1, 0, len - 1, down [i], up [i]);
            int rig = -query(ref seg [2], 1, 0, len - 1, down [i], up [i]);
            int use = now - Math.Max(0, lef + now - rig);
//            UnityEngine.Debug.Log("i:" + i + "," + now + "," + lef + "," + rig + "," + use + "," + (len - 1) + "," + down [i] + "," + up [i]);
            res += Math.Max(0, use - k);
            k = Math.Max(k, use);
            k = Math.Min(k, now);
        }
        return res;
    }
}
