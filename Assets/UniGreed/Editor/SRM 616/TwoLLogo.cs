using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class TwoLLogo
{
	int n, m;
	int[,] w, h;

	public long countWays(string[] grid)
	{
		n = grid.Length;
		m = grid [0].Length;
		w = new int[n, m];
		h = new int[n, m];

		for (int r0 = 0; r0 < n; r0++) {
			for (int c0 = 0; c0 < m; c0++) {
				for (int r = r0; r >= 0 && grid[r][c0] == '.'; r--) {
					h [r0, c0]++;
				}
				for (int c = c0; c < m && grid[r0][c] == '.'; c++) {
					w [r0, c0]++;
				}
			}
		}

		long res = 0;
		for (int rc0 = m; rc0 < n * m; rc0++) {
			int r0 = rc0 / m;
			int c0 = rc0 % m;
			if (grid [r0] [c0] == '#')
				continue;
			for (int rc1 = rc0 + 1; rc1 < n * m; rc1++) {
				int r1 = rc1 / m;
				int c1 = rc1 % m;
				if (grid [r1] [c1] == '#')
					continue;
				var v = Calculate(r0, c0, r1, c1);
				res += v;
			}
		}
		return res;
	}

	long Calculate(int r0, int c0, int r1, int c1)
	{
		if (r0 == 0)
			return 0;
		if (c0 == m - 1 || c1 == m - 1)
			return 0;
		if (r0 == r1) {
			return Math.Max(0, (Math.Min(w [r0, c0], c1 - c0) - 1) * (h [r0, c0] - 1) * (w [r1, c1] - 1) * (h [r1, c1] - 1));
		} else if (c0 == c1) {
			return Math.Max(0, (w [r0, c0] - 1) * (h [r0, c0] - 1) * (w [r1, c1] - 1) * (Math.Min(h [r1, c1], r1 - r0) - 1));
		} else {                            
			long res = Math.Max(0, (w [r0, c0] - 1) * (h [r0, c0] - 1) * (w [r1, c1] - 1) * (h [r1, c1] - 1));
			if (c1 < c0)
				return res;
            
			if (res == 0)
				return 0;
            
			if (c0 < c1) {
				if (c0 + w [r0, c0] < c1)
					return res;
				if (r0 + h [r1, c1] < r1)
					return res;
                
				return Math.Max(0, res - Math.Max(0, (c0 + w [r0, c0] - c1) * (r0 + h [r1, c1] - r1) * (w [r1, c1] - 1) * (h [r0, c0] - 1)));
			}
		}
		return 0;
	}
}
