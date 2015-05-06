using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class OddEvenTree
{
	public struct Edge
	{
		public int u, v;
		public Edge (int u, int v)
		{
			this.u = u;
			this.v = v;
		}
	}

	public class UnionFind
	{
		int[] parent;

		public UnionFind (int n)
		{
			parent = Enumerable.Range (0, n).ToArray ();
		}

		public int GetParent (int x)
		{
			if (x != parent [x]) {
				return parent [x] = GetParent (parent [x]);
			}
			return x;
		}

		public void Unite (int u, int v)
		{
			parent [GetParent (u)] = v;
		}

		public List<Edge> Edges = new List<Edge> ();

		public void Unite (Edge edge)
		{
			if (Edges.Count >= parent.Length - 1)
				return;
			Unite (edge.u, edge.v);
			Edges.Add (edge);
		}

		public bool AllUnite {
			get {
				if (Edges.Count != parent.Length - 1)
					return false;
				for (int i = 1; i < parent.Length; i++) {

					if (GetParent (0) != GetParent (i))
						return false;
				}
				return true;
			}
		}

		public int[] Result {
			get {
				var list = new List<int> ();
				foreach (var edge in Edges) {
					list.Add (edge.u);
					list.Add (edge.v);
				}
				return list.ToArray ();
			}
		}
	}

	public int[] getTree (string[] x)
	{
		int N = x.Length;
		for (int i = 0; i < N; i++) {
			if (x [i] [i] != 'E')
				return new int[]{ -1};
		}

		var edges = new List<Edge> ();
		for (int i = 0; i < N; i++) {
			for (int j = i+1; j < N; j++) {
				if (x [i] [j] != x [j] [i])
					return new int[] {-1};
				if (x [i] [j] == 'O')
					edges.Add (new Edge (i, j));
			}
		}

		var uf = new UnionFind (N);
		foreach (var edge in edges) {
			if (uf.GetParent (edge.u) != uf.GetParent (edge.v)) {
				uf.Unite (edge);
			}
		}

		if (uf.AllUnite) {
			return uf.Result;
		}

		return new int[] { -1};
	}

}
