using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Autogame
{
	public int wayscnt (int[] a, int K)
	{
		const int MOD = 1000000007;

		int N = a.Length;
		K = Math.Min (K, N - 1);

		var curr = Enumerable.Repeat (1, N).ToArray ();
		for (int i = 0; i < K; i++) {
			var nw = new int[N];
			for (int j = 0; j < N; j++) {
				nw [a [j] - 1] += curr [j];
			}
			curr = nw;
		}

		return (int)curr.Aggregate (1L, (acc, next) => acc * (next + 1) % MOD);
	}

}
