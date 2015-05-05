using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TaroCutting
{
    public int getNumber(int[] height, int[] add, int[] device, int time)
    {
        int n = height.Length;
        int m = device.Length;
        int U = n + m + time;
        int S = U + 1;
        int T = S + 1;
        var graph = new MincostGraph(T + 1);
        for (int i = 0; i < n; i++)
        {
            graph.addEdge(S, i, 1, 0);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < time; j++)
            {
                graph.addEdge(i, n + j, 1, add [i] * j);
            }
        }
        for (int i = 0; i < time; i++)
        {
            for (int j = 0; j < m; j++)
            {
                graph.addEdge(n + i, n + time + j, 1, 0);
            }
        }
        for (int i = 0; i < m; i++)
        {
            graph.addEdge(n + time + i, T, time, device [i]);
        }
        for (int i = 0; i < n; i++)
        {
            graph.addEdge(i, U, 1, height [i] + add [i] * time);
        }
        graph.addEdge(U, T, n, 0);
        return (int)graph.mincost(S, T, n);
    }

    public class MincostGraph
    {
        public class Edge
        { 
            public int to, cap;
            public long cost;
            public int rev;
        }
        const long infty = 1L << 60;
        List<Edge>[] graph;
        long[] dist;
        int[] prevv;
        int[] preve;
        public MincostGraph(int n)
        {
            graph = new List<Edge>[n];
            for (int i = 0; i< n; i++)
                graph [i] = new List<Edge>();
            dist = new long[n];
            prevv = new int[n];
            preve = new int[n];
        }
        
        public void addEdge(int from, int to, int cap, long cost)
        {
            Edge e1 = new Edge
            { to = to, cap=cap, cost=cost, rev=(int)graph [to].Count };
            Edge e2 = new Edge { to= from, cap= 0,cost= -cost, rev=(int)graph [from].Count };
            graph [from].Add(e1);
            graph [to].Add(e2);
        }
        
        public long mincost(int s, int t, int f)
        {
            long ret = 0;
            while (f > 0)
            {
                bellmanFord(s);
                if (dist [t] == infty)
                    return infty;
                
                int cap = f;
                for (int v = t; v != s; v = prevv[v])
                {
                    Edge e = graph [prevv [v]] [preve [v]];
                    cap = Math.Min(cap, e.cap);
                }
                
                f -= cap;
                ret += cap * dist [t];
                for (int v = t; v != s; v = prevv[v])
                {
                    var e = graph [prevv [v]] [preve [v]];
                    e.cap -= cap;
                    graph [v] [e.rev].cap += cap;
                }
            }
            return ret;
        }
        void bellmanFord(int s)
        {
            dist = Enumerable.Repeat(infty, dist.Count()).ToArray();
            dist [s] = 0;
            bool update = true;
            while (update)
            {
                update = false;
                for (int i = 0; i < graph.Length; i++)
                {
                    if (dist [i] == infty)
                        continue;
                    int n = graph [i].Count;
                    for (int j = 0; j < n; j++)
                    {
                        var e = graph [i] [j];
                        if (e.cap > 0 && dist [e.to] > dist [i] + e.cost)
                        {
                            dist [e.to] = dist [i] + e.cost;
                            prevv [e.to] = i;
                            preve [e.to] = j;
                            update = true;
                        }
                    }
                }
            }
        }
    }
}
