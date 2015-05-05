using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ChristmasTreeDecoration
{
	public class UnionFind
	{
		int[] parent;

		public UnionFind (int n)
		{
			parent = Enumerable.Range (0, n).ToArray ();
		}

		public int GetParent (int x)
		{
			if (x != parent [x])
				return parent [x] = GetParent (parent [x]);
			return x;
		}

		public void Unite (int u, int v)
		{
			parent [GetParent (u)] = v;
		}
	}

	public int solve (int[] col, int[] x, int[] y)
	{
		var edges = x.Zip (y, (i, j) => new { cost = col [i - 1] == col [j - 1] ? 1 : 0, u = i - 1, v = j - 1});

		var uf = new UnionFind (col.Length);

		int total = 0;
		foreach (var edge in edges.OrderBy(edge => edge.cost)) {
			if (uf.GetParent (edge.u) != uf.GetParent (edge.v)) {
				uf.Unite (edge.u, edge.v);
				total += edge.cost;
			}
		}
		
		return total;
	}

}
