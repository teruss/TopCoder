using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class TwoNumberGroups
{
    long mo = 1000000007;
    const int prime_max = 35000;
    int NP;
    int[] prime = new int[10000];
    int[]divp = new int[prime_max];
    
    List<int>[,] V = new List<int>[2, 100001];
    int[,] dif = new int[1001, 1001];
    
    void cprime()
    {
        for (int i=2; i<prime_max; i++)
            if (divp [i] == 0)
            {
                prime [NP++] = i;
                for (int j=i; j<prime_max; j+=i)
                    divp [j] = i;
            }
    }

    public int solve(int[] A, int[] numA, int[] B, int[] numB)
    {
        for (int i = 0; i < V.GetLength(0); i++)
            for (int j=0; j<V.GetLength(1); j++)
                V [i, j] = new List<int>();

        NP = 0;
        cprime();
        for (int x=0; x<A.Length; x++)
            for (int y=0; y<B.Length; y++)
                dif [x, y] = Math.Abs(A [x] - B [y]);
        
        long ret = 0;
        for (int i=0; i<NP; i++)
        {
            int p = prime [i];
            
            for (int x=0; x<A.Length; x++)
                V [0, A [x] % p].Add(x);
            for (int x=0; x<B.Length; x++)
                V [1, B [x] % p].Add(x);
            for (int j = 0; j < p; j++)
            {
                if (V [0, j].Count > 0 && V [1, j].Count > 0)
                {
                    foreach (var it in V[0,j])
                        foreach (var it2 in V[1,j])
                            if (dif [it, it2] > 1)
                            {
                                ret = (ret + 1L * numA [it] * numB [it2] % mo * p) % mo;
                                while (dif[it,it2]%p==0)
                                    dif [it, it2] /= p;
                            }
                }
                V [0, j].Clear();
                V [1, j].Clear();
            }
        }
        for (int x = 0; x <A.Length; x++)
            for (int y=0; y<B.Length; y++)
                if (dif [x, y] > 1)
                    ret = (ret + 1L * dif [x, y] * numA [x] % mo * numB [y]) % mo;
        
        return (int)(ret % mo);
    }

}
