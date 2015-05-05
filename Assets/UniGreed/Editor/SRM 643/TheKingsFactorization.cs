using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TheKingsFactorization
{
	public long[] getVector(long N, long[] primes)
	{
		var total = primes.Aggregate(1L, (acc, next) => acc * next);
		if (total == N)
			return primes;

		N /= total;
		var list = new List<long>(primes);

		for (int i = 2; i * i <= N && list.Count < primes.Length * 2 - 1; i++) {
			while (N % i == 0) {
				list.Add(i);
				N /= i;
			}
		}
		if (N > 1)
			list.Add(N);
		list.Sort();
		return list.ToArray();
	}

}
