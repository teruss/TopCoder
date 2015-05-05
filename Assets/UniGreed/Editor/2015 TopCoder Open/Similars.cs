using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Similars
{
	public int maxsim(int L, int R)
	{
		int res = 0;
		for (int l = L; l < R; l++) {
			var digitsL = Digits(l);
			if (digitsL.Count <= res)
				continue;
			for (int r = l + 1; r <= R; r++) {
				var digitsR = Digits(r);
				if (digitsR.Count <= res)
					continue;

				res = Math.Max(res, Sim(digitsL, digitsR));
				if (res == 5)
					return res;
			}
		}
		return res;
	}

	int Sim(HashSet<int> digitsL, HashSet<int> digitsR)
	{
		int c = 0;
		foreach (var dl in digitsL) {
			foreach (var dr in digitsR) {
				if (dl == dr) {
					c++;
					break;
				}
			}
		}
		return c;
	}

	HashSet<int> Digits(int n)
	{
		var list = new HashSet<int>();
		while (n > 0) {
			list.Add(n % 10);
			n /= 10;
		}
		return list;
	}
}
