using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TallShoes
{
    public int maxHeight(int N, int[] X, int[] Y, int[] height, long B)
    {
        int M = X.Length;
        
        long lb = 0, ub = 1000000000;
        while (lb + 1 < ub)
        {
            long mid = (lb + ub) / 2;
            
            var dijksra = new Dijkstra(N);
            for (int i = 0; i < M; i++)
            {
                int a = X [i], b = Y [i];
                long r = mid - height [i];
                long c = 0 < r ? r * r : 0;
                
                dijksra.connect(a, b, c);
                dijksra.connect(b, a, c);
            }
            
            if (dijksra.solve(0).Last() <= B)
                lb = mid;
            else
                ub = mid;
        }
        
        return (int)lb;
    }

    public class Dijkstra
    {
        readonly int V;
        List<KeyValuePair< int, long > >[] G;
        
        public    Dijkstra(int v)
        {
            V = v;
            G = new List<KeyValuePair<int, long>>[V];
            for (int i = 0; i < V; i++)
            {
                G [i] = new List<KeyValuePair<int, long>>();
            }
        }
        
        public void connect(int u, int v, long d)
        {
            G [u].Add(new KeyValuePair<int, long>(v, d));
        }
        
        public class Pair : IComparable<Pair>
        {
            public long Key;
            public int Value;
            
            public Pair(long key, int value)
            {
                Key = key;
                Value = value;
            }
            
            public int CompareTo(Pair other)
            {
                if (other == null)
                {
                    return 1;
                }
                
                return this.Key.CompareTo(other.Key);
            }
        }
        
        public long[] solve(int s, long d0 = 0)
        {
            var distances = Enumerable.Repeat(long.MaxValue, V).ToArray();
            distances [s] = d0;
            
            var que = new List<Pair>();
            que.Add(new Pair(d0, s));
            
            while (que.Count > 0)
            {
                long dist = que.Last().Key;
                int u = que.Last().Value;
                que.RemoveAt(que.Count - 1);
                
                if (distances [u] < dist)
                {
                    continue;
                }
                
                foreach (var e in G[u])
                {
                    int v = e.Key;
                    long d = e.Value;
                    
                    if (distances [u] + d < distances [v])
                    {
                        distances [v] = distances [u] + d;
                        var pair = new Pair(distances [v], v);
                        int index = que.BinarySearch(pair);
                        if (index < 0)
                            index = ~index;
                        que.Insert(index, pair);
                    }
                }
            }
            return distances;
        }
    }
}
