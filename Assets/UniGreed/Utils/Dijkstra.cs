using System;
using System.Collections.Generic;
using System.Linq;

namespace HebikuboLib
{
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
